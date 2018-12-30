using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CCWin;

namespace CashBook
{
	public partial class FormUpdate : Skin_Mac
	{
		FormCashBookMenu ver = new FormCashBookMenu();
		private SQLiteOperate sqlOper = new SQLiteOperate();

		public FormUpdate()
		{
			InitializeComponent();
			sqlOper.ConnectionToSqliteDB(); // 连接数据库
			this.Text = "当前版本: " + ver.GetVersion("mainVer");	// 版本号
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
		private void linkLabel_FeedBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FormFeedBack fb = new FormFeedBack();
			fb.ShowDialog();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		private void Btn_Update_Click(object sender, EventArgs e)
		{
			System.Diagnostics.ProcessStartInfo calcInfo = new System.Diagnostics.ProcessStartInfo();
			calcInfo.FileName = "https://pan.baidu.com/s/1LRROWR2BxA53V1tNeCp7Bw";
			System.Diagnostics.Process proc = System.Diagnostics.Process.Start(calcInfo);
		}

		#region 显示更新日志
		//显示更新日志
		public void ReadUpdateLog()
		{
			string get_update_log = "select * from t_update_log_info";
			string[] returnData = new string[2];
			returnData = sqlOper.SelectDataFromSqlite(get_update_log, returnData, 2);
			this.textBox_UpdateLog.Text = returnData[1];
		}
		#endregion

		private void FormUpdate_Load(object sender, EventArgs e)
		{
			ReadUpdateLog();	// 显示更新日志
		}
	}
}
