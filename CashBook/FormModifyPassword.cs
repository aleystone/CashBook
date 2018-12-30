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
	public partial class FormModifyPassword : Skin_Mac
	{
		private SQLiteOperate sqlOper = new SQLiteOperate();
		FormLogin frm = new FormLogin();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCashBookMenu));
		public FormModifyPassword()
		{
			InitializeComponent();
			sqlOper.ConnectionToSqliteDB(); // 连接数据库
			SetStyles();
			SetFormSkin(CashBookConfig.GetAppConfig("Skin"));
		}

		public void SetFormSkin(string skin)
		{
			switch (skin)
			{
				case "DefaultSkin": // 默认皮肤
					this.BackPalace = global::CashBook.Properties.Resources.DefaultSkin;
					break;
				case "PurpleSkin": // 炫彩紫色
					this.BackPalace = global::CashBook.Properties.Resources.PurpleSkin;
					break;
				case "LilySkin": // 悠然百合
					this.BackPalace = global::CashBook.Properties.Resources.LilySkin;
					break;
				case "GreenSkin": // 绿化环保
					this.BackPalace = global::CashBook.Properties.Resources.GreenSkin;
					break;
				case "LogCharm": // 原木韵味
					this.BackPalace = global::CashBook.Properties.Resources.LogCharm;
					break;
				case "SpringFestival": // 恭贺新春
					this.BackPalace = global::CashBook.Properties.Resources.SpringFestival;
					break;
			}
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

		private void Btn_ModCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Btn_ModifyOK_Click(object sender, EventArgs e)
		{
			MyMd5 md5 = new MyMd5();
			string strModPasswd1 = md5.Md5Encrypt(textBox_ModPasswd1.Text);
			string strModPasswd2 = md5.Md5Encrypt(textBox_ModPasswd2.Text);

			if (string.IsNullOrEmpty(strModPasswd1))
			{
				MessageBox.Show("亲，新密码不能为空哈！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (strModPasswd1.Length < 6)
			{
				MessageBox.Show("亲，新密码不能少于6位！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strModPasswd2))
			{
				MessageBox.Show("亲，确认密码不能为空！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (strModPasswd2.Length < 6)
			{
				MessageBox.Show("亲，确认密码不能少于6位！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (!string.Equals(strModPasswd1, strModPasswd2))
			{
				MessageBox.Show("亲，两次输入的密码不一致！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			const string TableUsers = "t_users";
			string sql_update_t_users = string.Format("UPDATE {0} SET PWD='{1}' WHERE ACC='{2}'", TableUsers, strModPasswd1, frm.GetAccount());
			sqlOper.ExecuteSql(sql_update_t_users);
			MessageBox.Show("恭喜！密码修改成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}
	}
}
