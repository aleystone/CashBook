using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;
using System.IO;
using CCWin;

namespace CashBook
{
	public partial class FormLogin : Skin_Mac
	{
		private SQLiteOperate sqlOper = new SQLiteOperate();
		private static string MainUserName = string.Empty;
		private static string MainAcc = string.Empty;
		private const string TableUsers = "t_users";
		private const string TableLog = "t_update_log_info";
		private string sql_create_t_users = string.Format("CREATE TABLE {0} (UID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,UNAME TEXT(15) NOT NULL,ACC TEXT(20) NOT NULL,PWD TEXT(32) NOT NULL,EMAIL TEXT(50) NOT NULL)", TableUsers);
		private string sql_create_t_update_log_info = string.Format("CREATE TABLE {0} (ID  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, UPDATE_LOG_INFO  TEXT NOT NULL)", TableLog);

		public FormLogin()
		{
			InitializeComponent();
			sqlOper.CreateSqliteDBFile();	// 创建数据库文件
			sqlOper.ConnectionToSqliteDB(); // 连接数据库
			sqlOper.CreateTableToSqlite(TableUsers, sql_create_t_users);	// 创建t_user表
			sqlOper.CreateTableToSqlite(TableLog, sql_create_t_update_log_info);	// 建表t_update_log_info
			SetStyles();
		}

		#region 减少闪烁
		//减少闪烁
		private void SetStyles()
		{
			base.SetStyle(
			  ControlStyles.UserPaint |
			  ControlStyles.AllPaintingInWmPaint |
			  ControlStyles.OptimizedDoubleBuffer |
			  ControlStyles.ResizeRedraw |
			  ControlStyles.DoubleBuffer, true);
			base.UpdateStyles();
			base.AutoScaleMode = AutoScaleMode.None;
		}
		#endregion 
		
		public string GetUserName()
		{
			return MainUserName;
		}

		public string GetAccount()
		{
			return MainAcc;
		}

		#region 登录
		// 登录
		private void Btn_Login_Click(object sender, EventArgs e)
		{
			MyMd5 md5 = new MyMd5();
			string strLoginAccount = textBox_Account.Text;  // 登录帐号
			string strLoginPasswd = md5.Md5Encrypt(textBox_Passwd.Text);    // 登录密码
			MainAcc = strLoginAccount;
			System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"^[A-Za-z0-9]+$");
			if (string.IsNullOrEmpty(strLoginAccount))
			{
				MessageBox.Show("亲，帐号不能为空呦！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (!reg.IsMatch(strLoginAccount))
			{
				MessageBox.Show("亲, 帐号只能由字母和数字组成！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (string.IsNullOrEmpty(strLoginPasswd))
			{
				MessageBox.Show("亲，密码不能为空哈！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (strLoginPasswd.Length < 6)
			{
				MessageBox.Show("亲，密码不能少于6位", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string sql_query_data = string.Format("SELECT * FROM {0} WHERE ACC='{1}'", TableUsers, strLoginAccount);
			string[] returnData = new string[4];
			// 查询数据库将数据保存至数组returnData
			returnData = sqlOper.SelectDataFromSqlite(sql_query_data, returnData, 4);
			if (strLoginAccount.Equals(returnData[2]) && strLoginPasswd.Equals(returnData[3]))
			{
				MainUserName = returnData[1];	// 获取登录用户名
				// 登录验证成功后关闭登录界面，显示记账主界面
				this.DialogResult = DialogResult.OK;
				this.Close();   // 关闭登录界面
			}
			else
			{
				MessageBox.Show("登录失败，帐号不存在或密码错误！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.textBox_Passwd.Text = string.Empty;
				return;
			}
		}
		#endregion

		#region 注册帐号
		// 注册帐号
		private void linkLabel_RegAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// 注册界面
			FormRegAccount objDialog = new FormRegAccount(this);
			this.Hide();
			objDialog.ShowDialog(this);
		}
		#endregion


		// 忘记密码界面
		private void linkLabel_ForgetPasswd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FormForgetPassword objDialog = new FormForgetPassword();
			objDialog.ShowDialog(this);
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{
			ThreadStart threadStart = new ThreadStart(ReadUpdateLog);
			Thread thread = new Thread(threadStart);
			thread.IsBackground = true;	// 后台运行线程
			thread.Start();		// 启动线程
		}

		private void ReadUpdateLog()
		{
			string LogFile = @".\更新日志.txt";	// 日志文件名
			const int DEFAULT_LOG_LEN = 32;		// 日志内容长度
			string UpdateLog = string.Empty;
			string get_update_log = string.Format("select * from {0}", TableLog);
			// 日志文件不存在即创建日志文件
			if (!(System.IO.File.Exists(LogFile)))
			{
				System.Data.SQLite.SQLiteConnection.CreateFile(LogFile);
			}

			// 日志文件存在但内容为空，将日志信息写入文件
			try
			{
				StreamReader srTemp = new StreamReader(LogFile);
				if (srTemp.ReadToEnd().Length < DEFAULT_LOG_LEN)
				{
					srTemp.Close();
					string[] returnData = new string[2];
					returnData = sqlOper.SelectDataFromSqlite(get_update_log, returnData, 2);
					FileStream fs = new FileStream(LogFile, FileMode.Open);
					StreamWriter sw = new StreamWriter(fs);
					// 更新记录文件不存在就将日志写入文件
					sw.Write(returnData[1]);
					sw.Flush();	// 清空缓冲区
					// 关闭流
					sw.Close();
					fs.Close();
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			StreamReader sr = new StreamReader(LogFile);// Encoding.Default
			String line;
			try
			{
				// 逐行从文件读取最新更新内容显示到界面并储存至数据库
				while ((line = sr.ReadLine()) != null)
				{
					UpdateLog += line + System.Environment.NewLine;
					if (sr.EndOfStream)
					{
						string[] returnData = new string[1];
						returnData = sqlOper.SelectDataFromSqlite(get_update_log, returnData, 1);
						if (string.IsNullOrEmpty(returnData[0]))
						{
							string sql_init_table = string.Format("insert into {0} values(NULL, 'Init String')", TableLog);
							sqlOper.ExecuteSql(sql_init_table);
						}
						string sql_update_log = string.Format("update {0} set UPDATE_LOG_INFO='{1}'", TableLog, UpdateLog);
						sqlOper.ExecuteSql(sql_update_log);
						break;
					}
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			sr.Close();	// 关闭流
		}
	}
}
