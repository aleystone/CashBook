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
	public partial class FormFeedBack : Skin_Mac
	{
		public FormFeedBack()
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

		private void Btn_Submit_Click(object sender, EventArgs e)
		{
			if (!skinRadioButton_Suggest.Checked && !skinRadioButton_Error.Checked && !skinRadioButton_Other.Checked)
			{
				MessageBox.Show("请选择反馈类型", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"^[A-Za-z0-9.]+$");
			string contentType = string.Empty;
			string MsgSubject = "小白兔记账本反馈-";
			if (this.skinRadioButton_Suggest.Checked)
			{
				contentType = skinRadioButton_Suggest.Text;
				MsgSubject += skinRadioButton_Suggest.Text;
			}
			else if (this.skinRadioButton_Error.Checked)
			{
				contentType = skinRadioButton_Error.Text;
				MsgSubject += skinRadioButton_Error.Text;
			}
			else if (this.skinRadioButton_Other.Checked)
			{
				contentType = skinRadioButton_Other.Text;
				MsgSubject += skinRadioButton_Other.Text;
			}

			if (string.IsNullOrEmpty(this.skinTextBox_FeedBackContent.Text))
			{
				MessageBox.Show("亲，请输入反馈内容！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			else if (!string.IsNullOrEmpty(skinTextBox_Contact.Text) && !reg.IsMatch(skinTextBox_Contact.Text))
			{
				MessageBox.Show("亲, 请检查联系方式是否合法！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				SendFeedBack fb = new SendFeedBack();
				string Msg = string.Format("<p><b>反馈类型：</b>{0}</p><p><b>反馈内容：</b><blockquote style=line-height:2>{1}</p></blockquote><p><b>联系方式：</b><font color=blue>{2}</font></p>", contentType, skinTextBox_FeedBackContent.Text, skinTextBox_Contact.Text);
				if (fb.SendMsg(MsgSubject, Msg))
				{
					MessageBox.Show("感谢您的反馈，么么哒~", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.skinTextBox_FeedBackContent.Text = string.Empty;
				}
				else
				{
					MessageBox.Show("您的反馈发送失败，请检查网络配置！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
	}
}
