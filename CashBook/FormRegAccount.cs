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
using System.Text.RegularExpressions;
using CCWin;

namespace CashBook
{
	public partial class FormRegAccount : Skin_Mac
	{
		private FormLogin returnFrom_formLogin = null;
		// 创建连接数据库的对象
		private SQLiteOperate connSqlite = new SQLiteOperate();

		public FormRegAccount(FormLogin formLogin)
		{
			InitializeComponent();
			this.returnFrom_formLogin = formLogin;
			connSqlite.ConnectionToSqliteDB();	// 连接到数据库
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

		#region FormClosing事件
		// FormClosing事件
		private void FormRegAccount_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.returnFrom_formLogin.Visible = true;
		}
		#endregion

		#region 立即注册
		// 立即注册
		private void Btn_Reg_Click(object sender, EventArgs e)
		{
			// 获取控件值
			MyMd5 md5 = new MyMd5();
			const string TableUsers = "t_users";
			string strRegUserName = textBox_RegUserName.Text;	// 用户名 长度3-15字符
			string strRegAcc = textBox_RegAccount.Text;			// 注册帐号 长度6-20字符
			// 注册密码 长度6-20字母，数字或符号，采用MD5加密
			string strRegPasswd1 = md5.Md5Encrypt(textBox_RegPasswd1.Text);		
			// 确认注册密码
			string strRegPasswd2 = md5.Md5Encrypt(textBox_RegPasswd2.Text);		
			string strRegEmail = textBox_RegEmail.Text;			// 注册邮箱
			string sql_query_t_users = string.Format("SELECT * FROM {0} WHERE ACC='{1}'", TableUsers, strRegAcc);
			string[] returnData = new string[5];
			returnData = connSqlite.SelectDataFromSqlite(sql_query_t_users, returnData, 5);


			// 用户名
			if (string.IsNullOrEmpty(strRegUserName))
			{
				MessageBox.Show("亲，用户名不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (strRegUserName.Length < 2)
			{
				MessageBox.Show("亲，用户名不能少于2个字符！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			// 帐号
			System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"^[A-Za-z0-9]+$");
			if (string.IsNullOrEmpty(strRegAcc))
			{
				MessageBox.Show("亲，帐号不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (!reg.IsMatch(strRegAcc))
			{
				MessageBox.Show("亲, 帐号只能由字母和数字组成！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.Equals(strRegAcc, returnData[2]))
			{
				MessageBox.Show("亲，该帐号已注册，请更换帐号或登录！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			// 密码
			if (string.IsNullOrEmpty(strRegPasswd1))
			{
				MessageBox.Show("亲，密码不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (strRegPasswd1.Length < 6)
			{
				MessageBox.Show("亲，密码不能少于6位！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strRegPasswd2))
			{
				MessageBox.Show("亲，确认密码不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (strRegPasswd2.Length < 6)
			{
				MessageBox.Show("亲，确认密码不能少于6位！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (!string.Equals(strRegPasswd1, strRegPasswd2))
			{
				MessageBox.Show("两次输入的密码不一致！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			// 邮箱
			string expression = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

			if (string.IsNullOrEmpty(strRegEmail))
			{
				MessageBox.Show("亲，邮箱不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (!Regex.IsMatch(strRegEmail, expression, RegexOptions.Compiled))
			{
				MessageBox.Show("对不起，邮箱格式不正确！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string sql_insert_t_users = string.Format("INSERT INTO {0} VALUES(NULL, '{1}', '{2}', '{3}', '{4}')", TableUsers, strRegUserName, strRegAcc, strRegPasswd1, strRegEmail);
			connSqlite.ExecuteSql(sql_insert_t_users);
			MessageBox.Show("恭喜！注册成功，请用该帐号登录！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();   // 关闭注册窗体
		}
		#endregion

	}
}
