namespace CashBook
{
	partial class FormRegAccount
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegAccount));
			this.Btn_Reg = new CCWin.SkinControl.SkinButton();
			this.label_RegUserName = new CCWin.SkinControl.SkinLabel();
			this.label_RegAccount = new CCWin.SkinControl.SkinLabel();
			this.label_RegPasswd1 = new CCWin.SkinControl.SkinLabel();
			this.label_RegPasswd2 = new CCWin.SkinControl.SkinLabel();
			this.label_RegEmail = new CCWin.SkinControl.SkinLabel();
			this.textBox_RegUserName = new CCWin.SkinControl.SkinTextBox();
			this.textBox_RegAccount = new CCWin.SkinControl.SkinTextBox();
			this.textBox_RegPasswd1 = new CCWin.SkinControl.SkinTextBox();
			this.textBox_RegPasswd2 = new CCWin.SkinControl.SkinTextBox();
			this.textBox_RegEmail = new CCWin.SkinControl.SkinTextBox();
			this.SuspendLayout();
			// 
			// Btn_Reg
			// 
			this.Btn_Reg.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Reg.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
			this.Btn_Reg.BorderColor = System.Drawing.Color.Empty;
			this.Btn_Reg.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.Btn_Reg.DownBack = null;
			this.Btn_Reg.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(189)))), ((int)(((byte)(253)))));
			this.Btn_Reg.FadeGlow = false;
			this.Btn_Reg.Font = new System.Drawing.Font("微软雅黑", 10F);
			this.Btn_Reg.ForeColor = System.Drawing.Color.White;
			this.Btn_Reg.InnerBorderColor = System.Drawing.Color.Empty;
			this.Btn_Reg.IsDrawGlass = false;
			this.Btn_Reg.Location = new System.Drawing.Point(52, 300);
			this.Btn_Reg.MouseBack = null;
			this.Btn_Reg.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(134)))), ((int)(((byte)(253)))));
			this.Btn_Reg.Name = "Btn_Reg";
			this.Btn_Reg.NormlBack = null;
			this.Btn_Reg.Radius = 4;
			this.Btn_Reg.RoundStyle = CCWin.SkinClass.RoundStyle.All;
			this.Btn_Reg.Size = new System.Drawing.Size(246, 43);
			this.Btn_Reg.TabIndex = 5;
			this.Btn_Reg.Text = "立即注册";
			this.Btn_Reg.UseVisualStyleBackColor = false;
			this.Btn_Reg.Click += new System.EventHandler(this.Btn_Reg_Click);
			// 
			// label_RegUserName
			// 
			this.label_RegUserName.AutoSize = true;
			this.label_RegUserName.BackColor = System.Drawing.Color.Transparent;
			this.label_RegUserName.BorderColor = System.Drawing.Color.White;
			this.label_RegUserName.Font = new System.Drawing.Font("微软雅黑", 10F);
			this.label_RegUserName.Location = new System.Drawing.Point(41, 61);
			this.label_RegUserName.Name = "label_RegUserName";
			this.label_RegUserName.Size = new System.Drawing.Size(77, 20);
			this.label_RegUserName.TabIndex = 1;
			this.label_RegUserName.Text = "用 户  名：";
			// 
			// label_RegAccount
			// 
			this.label_RegAccount.AutoSize = true;
			this.label_RegAccount.BackColor = System.Drawing.Color.Transparent;
			this.label_RegAccount.BorderColor = System.Drawing.Color.White;
			this.label_RegAccount.Font = new System.Drawing.Font("微软雅黑", 10F);
			this.label_RegAccount.Location = new System.Drawing.Point(39, 102);
			this.label_RegAccount.Name = "label_RegAccount";
			this.label_RegAccount.Size = new System.Drawing.Size(79, 20);
			this.label_RegAccount.TabIndex = 2;
			this.label_RegAccount.Text = "帐       号：";
			// 
			// label_RegPasswd1
			// 
			this.label_RegPasswd1.AutoSize = true;
			this.label_RegPasswd1.BackColor = System.Drawing.Color.Transparent;
			this.label_RegPasswd1.BorderColor = System.Drawing.Color.White;
			this.label_RegPasswd1.Font = new System.Drawing.Font("微软雅黑", 10F);
			this.label_RegPasswd1.Location = new System.Drawing.Point(39, 143);
			this.label_RegPasswd1.Name = "label_RegPasswd1";
			this.label_RegPasswd1.Size = new System.Drawing.Size(79, 20);
			this.label_RegPasswd1.TabIndex = 3;
			this.label_RegPasswd1.Text = "密       码：";
			// 
			// label_RegPasswd2
			// 
			this.label_RegPasswd2.AutoSize = true;
			this.label_RegPasswd2.BackColor = System.Drawing.Color.Transparent;
			this.label_RegPasswd2.BorderColor = System.Drawing.Color.White;
			this.label_RegPasswd2.Font = new System.Drawing.Font("微软雅黑", 10F);
			this.label_RegPasswd2.Location = new System.Drawing.Point(39, 184);
			this.label_RegPasswd2.Name = "label_RegPasswd2";
			this.label_RegPasswd2.Size = new System.Drawing.Size(79, 20);
			this.label_RegPasswd2.TabIndex = 4;
			this.label_RegPasswd2.Text = "确认密码：";
			// 
			// label_RegEmail
			// 
			this.label_RegEmail.AutoSize = true;
			this.label_RegEmail.BackColor = System.Drawing.Color.Transparent;
			this.label_RegEmail.BorderColor = System.Drawing.Color.White;
			this.label_RegEmail.Font = new System.Drawing.Font("微软雅黑", 10F);
			this.label_RegEmail.Location = new System.Drawing.Point(39, 225);
			this.label_RegEmail.Name = "label_RegEmail";
			this.label_RegEmail.Size = new System.Drawing.Size(79, 20);
			this.label_RegEmail.TabIndex = 5;
			this.label_RegEmail.Text = "电子邮箱：";
			// 
			// textBox_RegUserName
			// 
			this.textBox_RegUserName.BackColor = System.Drawing.Color.Transparent;
			this.textBox_RegUserName.DownBack = null;
			this.textBox_RegUserName.Icon = null;
			this.textBox_RegUserName.IconIsButton = false;
			this.textBox_RegUserName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_RegUserName.IsPasswordChat = '\0';
			this.textBox_RegUserName.IsSystemPasswordChar = false;
			this.textBox_RegUserName.Lines = new string[0];
			this.textBox_RegUserName.Location = new System.Drawing.Point(124, 57);
			this.textBox_RegUserName.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_RegUserName.MaxLength = 20;
			this.textBox_RegUserName.MinimumSize = new System.Drawing.Size(28, 28);
			this.textBox_RegUserName.MouseBack = null;
			this.textBox_RegUserName.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_RegUserName.Multiline = false;
			this.textBox_RegUserName.Name = "textBox_RegUserName";
			this.textBox_RegUserName.NormlBack = null;
			this.textBox_RegUserName.Padding = new System.Windows.Forms.Padding(5);
			this.textBox_RegUserName.ReadOnly = false;
			this.textBox_RegUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.textBox_RegUserName.Size = new System.Drawing.Size(185, 28);
			// 
			// 
			// 
			this.textBox_RegUserName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_RegUserName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_RegUserName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.textBox_RegUserName.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.textBox_RegUserName.SkinTxt.MaxLength = 20;
			this.textBox_RegUserName.SkinTxt.Name = "BaseText";
			this.textBox_RegUserName.SkinTxt.Size = new System.Drawing.Size(175, 18);
			this.textBox_RegUserName.SkinTxt.TabIndex = 0;
			this.textBox_RegUserName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_RegUserName.SkinTxt.WaterText = "";
			this.textBox_RegUserName.TabIndex = 0;
			this.textBox_RegUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.textBox_RegUserName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_RegUserName.WaterText = "";
			this.textBox_RegUserName.WordWrap = true;
			// 
			// textBox_RegAccount
			// 
			this.textBox_RegAccount.BackColor = System.Drawing.Color.Transparent;
			this.textBox_RegAccount.DownBack = null;
			this.textBox_RegAccount.Icon = null;
			this.textBox_RegAccount.IconIsButton = false;
			this.textBox_RegAccount.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_RegAccount.IsPasswordChat = '\0';
			this.textBox_RegAccount.IsSystemPasswordChar = false;
			this.textBox_RegAccount.Lines = new string[0];
			this.textBox_RegAccount.Location = new System.Drawing.Point(124, 98);
			this.textBox_RegAccount.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_RegAccount.MaxLength = 20;
			this.textBox_RegAccount.MinimumSize = new System.Drawing.Size(28, 28);
			this.textBox_RegAccount.MouseBack = null;
			this.textBox_RegAccount.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_RegAccount.Multiline = false;
			this.textBox_RegAccount.Name = "textBox_RegAccount";
			this.textBox_RegAccount.NormlBack = null;
			this.textBox_RegAccount.Padding = new System.Windows.Forms.Padding(5);
			this.textBox_RegAccount.ReadOnly = false;
			this.textBox_RegAccount.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.textBox_RegAccount.Size = new System.Drawing.Size(185, 28);
			// 
			// 
			// 
			this.textBox_RegAccount.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_RegAccount.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_RegAccount.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.textBox_RegAccount.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.textBox_RegAccount.SkinTxt.MaxLength = 20;
			this.textBox_RegAccount.SkinTxt.Name = "BaseText";
			this.textBox_RegAccount.SkinTxt.Size = new System.Drawing.Size(175, 18);
			this.textBox_RegAccount.SkinTxt.TabIndex = 0;
			this.textBox_RegAccount.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_RegAccount.SkinTxt.WaterText = "";
			this.textBox_RegAccount.TabIndex = 1;
			this.textBox_RegAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.textBox_RegAccount.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_RegAccount.WaterText = "";
			this.textBox_RegAccount.WordWrap = true;
			// 
			// textBox_RegPasswd1
			// 
			this.textBox_RegPasswd1.BackColor = System.Drawing.Color.Transparent;
			this.textBox_RegPasswd1.DownBack = null;
			this.textBox_RegPasswd1.Icon = null;
			this.textBox_RegPasswd1.IconIsButton = false;
			this.textBox_RegPasswd1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_RegPasswd1.IsPasswordChat = '●';
			this.textBox_RegPasswd1.IsSystemPasswordChar = true;
			this.textBox_RegPasswd1.Lines = new string[0];
			this.textBox_RegPasswd1.Location = new System.Drawing.Point(124, 139);
			this.textBox_RegPasswd1.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_RegPasswd1.MaxLength = 20;
			this.textBox_RegPasswd1.MinimumSize = new System.Drawing.Size(28, 28);
			this.textBox_RegPasswd1.MouseBack = null;
			this.textBox_RegPasswd1.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_RegPasswd1.Multiline = false;
			this.textBox_RegPasswd1.Name = "textBox_RegPasswd1";
			this.textBox_RegPasswd1.NormlBack = null;
			this.textBox_RegPasswd1.Padding = new System.Windows.Forms.Padding(5);
			this.textBox_RegPasswd1.ReadOnly = false;
			this.textBox_RegPasswd1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.textBox_RegPasswd1.Size = new System.Drawing.Size(185, 28);
			// 
			// 
			// 
			this.textBox_RegPasswd1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_RegPasswd1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_RegPasswd1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.textBox_RegPasswd1.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.textBox_RegPasswd1.SkinTxt.MaxLength = 20;
			this.textBox_RegPasswd1.SkinTxt.Name = "BaseText";
			this.textBox_RegPasswd1.SkinTxt.PasswordChar = '●';
			this.textBox_RegPasswd1.SkinTxt.Size = new System.Drawing.Size(175, 18);
			this.textBox_RegPasswd1.SkinTxt.TabIndex = 0;
			this.textBox_RegPasswd1.SkinTxt.UseSystemPasswordChar = true;
			this.textBox_RegPasswd1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_RegPasswd1.SkinTxt.WaterText = "";
			this.textBox_RegPasswd1.TabIndex = 2;
			this.textBox_RegPasswd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.textBox_RegPasswd1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_RegPasswd1.WaterText = "";
			this.textBox_RegPasswd1.WordWrap = true;
			// 
			// textBox_RegPasswd2
			// 
			this.textBox_RegPasswd2.BackColor = System.Drawing.Color.Transparent;
			this.textBox_RegPasswd2.DownBack = null;
			this.textBox_RegPasswd2.Icon = null;
			this.textBox_RegPasswd2.IconIsButton = false;
			this.textBox_RegPasswd2.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_RegPasswd2.IsPasswordChat = '●';
			this.textBox_RegPasswd2.IsSystemPasswordChar = true;
			this.textBox_RegPasswd2.Lines = new string[0];
			this.textBox_RegPasswd2.Location = new System.Drawing.Point(124, 180);
			this.textBox_RegPasswd2.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_RegPasswd2.MaxLength = 20;
			this.textBox_RegPasswd2.MinimumSize = new System.Drawing.Size(28, 28);
			this.textBox_RegPasswd2.MouseBack = null;
			this.textBox_RegPasswd2.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_RegPasswd2.Multiline = false;
			this.textBox_RegPasswd2.Name = "textBox_RegPasswd2";
			this.textBox_RegPasswd2.NormlBack = null;
			this.textBox_RegPasswd2.Padding = new System.Windows.Forms.Padding(5);
			this.textBox_RegPasswd2.ReadOnly = false;
			this.textBox_RegPasswd2.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.textBox_RegPasswd2.Size = new System.Drawing.Size(185, 28);
			// 
			// 
			// 
			this.textBox_RegPasswd2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_RegPasswd2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_RegPasswd2.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.textBox_RegPasswd2.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.textBox_RegPasswd2.SkinTxt.MaxLength = 20;
			this.textBox_RegPasswd2.SkinTxt.Name = "BaseText";
			this.textBox_RegPasswd2.SkinTxt.PasswordChar = '●';
			this.textBox_RegPasswd2.SkinTxt.Size = new System.Drawing.Size(175, 18);
			this.textBox_RegPasswd2.SkinTxt.TabIndex = 0;
			this.textBox_RegPasswd2.SkinTxt.UseSystemPasswordChar = true;
			this.textBox_RegPasswd2.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_RegPasswd2.SkinTxt.WaterText = "";
			this.textBox_RegPasswd2.TabIndex = 3;
			this.textBox_RegPasswd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.textBox_RegPasswd2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_RegPasswd2.WaterText = "";
			this.textBox_RegPasswd2.WordWrap = true;
			// 
			// textBox_RegEmail
			// 
			this.textBox_RegEmail.BackColor = System.Drawing.Color.Transparent;
			this.textBox_RegEmail.DownBack = null;
			this.textBox_RegEmail.Icon = null;
			this.textBox_RegEmail.IconIsButton = false;
			this.textBox_RegEmail.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_RegEmail.IsPasswordChat = '\0';
			this.textBox_RegEmail.IsSystemPasswordChar = false;
			this.textBox_RegEmail.Lines = new string[0];
			this.textBox_RegEmail.Location = new System.Drawing.Point(124, 221);
			this.textBox_RegEmail.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_RegEmail.MaxLength = 40;
			this.textBox_RegEmail.MinimumSize = new System.Drawing.Size(28, 28);
			this.textBox_RegEmail.MouseBack = null;
			this.textBox_RegEmail.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_RegEmail.Multiline = false;
			this.textBox_RegEmail.Name = "textBox_RegEmail";
			this.textBox_RegEmail.NormlBack = null;
			this.textBox_RegEmail.Padding = new System.Windows.Forms.Padding(5);
			this.textBox_RegEmail.ReadOnly = false;
			this.textBox_RegEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.textBox_RegEmail.Size = new System.Drawing.Size(185, 28);
			// 
			// 
			// 
			this.textBox_RegEmail.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_RegEmail.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_RegEmail.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.textBox_RegEmail.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.textBox_RegEmail.SkinTxt.MaxLength = 40;
			this.textBox_RegEmail.SkinTxt.Name = "BaseText";
			this.textBox_RegEmail.SkinTxt.Size = new System.Drawing.Size(175, 18);
			this.textBox_RegEmail.SkinTxt.TabIndex = 0;
			this.textBox_RegEmail.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_RegEmail.SkinTxt.WaterText = "";
			this.textBox_RegEmail.TabIndex = 4;
			this.textBox_RegEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.textBox_RegEmail.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_RegEmail.WaterText = "";
			this.textBox_RegEmail.WordWrap = true;
			// 
			// FormRegAccount
			// 
			this.AcceptButton = this.Btn_Reg;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(95)))), ((int)(((byte)(205)))));
			this.CaptionBackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
			this.CaptionBackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
			this.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
			this.ClientSize = new System.Drawing.Size(351, 365);
			this.Controls.Add(this.textBox_RegEmail);
			this.Controls.Add(this.textBox_RegPasswd2);
			this.Controls.Add(this.textBox_RegPasswd1);
			this.Controls.Add(this.textBox_RegAccount);
			this.Controls.Add(this.textBox_RegUserName);
			this.Controls.Add(this.label_RegEmail);
			this.Controls.Add(this.label_RegPasswd2);
			this.Controls.Add(this.label_RegPasswd1);
			this.Controls.Add(this.label_RegAccount);
			this.Controls.Add(this.label_RegUserName);
			this.Controls.Add(this.Btn_Reg);
			this.EffectBack = System.Drawing.Color.Black;
			this.EffectWidth = 5;
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.InnerBorderColor = System.Drawing.Color.Empty;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRegAccount";
			this.Radius = 3;
			this.Text = "小白兔记账本 • 注册";
			this.TitleCenter = false;
			this.TitleColor = System.Drawing.Color.White;
			this.TitleOffset = new System.Drawing.Point(0, 4);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegAccount_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CCWin.SkinControl.SkinButton Btn_Reg;
		private CCWin.SkinControl.SkinLabel label_RegUserName;
		private CCWin.SkinControl.SkinLabel label_RegAccount;
		private CCWin.SkinControl.SkinLabel label_RegPasswd1;
		private CCWin.SkinControl.SkinLabel label_RegPasswd2;
		private CCWin.SkinControl.SkinLabel label_RegEmail;
		private CCWin.SkinControl.SkinTextBox textBox_RegUserName;
		private CCWin.SkinControl.SkinTextBox textBox_RegAccount;
		private CCWin.SkinControl.SkinTextBox textBox_RegPasswd1;
		private CCWin.SkinControl.SkinTextBox textBox_RegPasswd2;
		private CCWin.SkinControl.SkinTextBox textBox_RegEmail;
	}
}