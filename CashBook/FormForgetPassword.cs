using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace CashBook
{
	public partial class FormForgetPassword : Skin_Mac
	{
		private SQLiteOperate sqlOper = new SQLiteOperate();
		public FormForgetPassword()
		{
			InitializeComponent();

			sqlOper.ConnectionToSqliteDB(); // 连接数据库
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

		#region 保存密码修改
		// 保存密码修改
		private void Btn_ModifyPassword_Click(object sender, EventArgs e)
		{
			MyMd5 md5 = new MyMd5();
			string strModifyAcc = textBox_ModifyAcc.Text;
			string strModifyEmail = textBox_ModifyEmail.Text;
			string strModifyPasswd1 = md5.Md5Encrypt(textBox_ModifyPasswd1.Text);
			string strModifyPasswd2 = md5.Md5Encrypt(textBox_ModifyPasswd2.Text);
			const string TableUsers = "t_users";
			string sql_query_data = string.Format("SELECT * FROM {0} WHERE ACC='{1}'", TableUsers, strModifyAcc);
			string sql_update_t_users = string.Format("UPDATE {0} SET PWD='{1}' WHERE ACC='{2}' AND EMAIL='{3}'", TableUsers, strModifyPasswd1, strModifyAcc, strModifyEmail);
			string[] returnData = new string[5];
			returnData = sqlOper.SelectDataFromSqlite(sql_query_data, returnData, 5);
			System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"^[A-Za-z0-9]+$");

			if (string.IsNullOrEmpty(strModifyAcc))
			{
				MessageBox.Show("亲, 帐号不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (!reg.IsMatch(strModifyAcc))
			{
				MessageBox.Show("亲, 帐号只能由字母和数字组成！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (strModifyAcc != returnData[2])
			{
				MessageBox.Show("亲, 帐号不正确或不存在！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strModifyEmail))
			{
				MessageBox.Show("亲, 邮箱不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (!strModifyEmail.Equals(returnData[4]))
			{
				MessageBox.Show("亲, 邮箱不正确！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strModifyPasswd1))
			{
				MessageBox.Show("亲, 新密码不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (strModifyPasswd1.Length < 6)
			{
				MessageBox.Show("亲, 新密码不能少于6位！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strModifyPasswd2))
			{
				MessageBox.Show("亲, 确认密码不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (strModifyPasswd2.Length < 6)
			{
				MessageBox.Show("亲, 确认密码不能少于6位！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (!string.Equals(strModifyPasswd1, strModifyPasswd2))
			{
				MessageBox.Show("两次输入的密码不一致！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				sqlOper.ExecuteSql(sql_update_t_users);
				MessageBox.Show("恭喜！密码修改成功，请用新密码登录！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
		}

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			// 关闭窗体
			this.Close();
		}
		#endregion

	}
}
