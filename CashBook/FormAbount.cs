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
	public partial class FormAbount : Skin_Mac
	{
		FormCashBookMenu frmAbout = new FormCashBookMenu();
		public FormAbount()
		{
			InitializeComponent();
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

		private void Btn_OK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormAbount_Load(object sender, EventArgs e)
		{
			this.skinLabel_About.Text = string.Format("小白兔记账本，v{0}版", frmAbout.GetVersion());
		}
	}
}
