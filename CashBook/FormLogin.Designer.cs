namespace CashBook
{
	partial class FormLogin
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.textBox_Account = new CCWin.SkinControl.SkinTextBox();
			this.textBox_Passwd = new CCWin.SkinControl.SkinTextBox();
			this.Btn_Login = new CCWin.SkinControl.SkinButton();
			this.linkLabel_RegAccount = new System.Windows.Forms.LinkLabel();
			this.linkLabel_ForgetPasswd = new System.Windows.Forms.LinkLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox_Account
			// 
			this.textBox_Account.BackColor = System.Drawing.Color.Transparent;
			this.textBox_Account.DownBack = null;
			this.textBox_Account.Icon = global::CashBook.Properties.Resources.user;
			this.textBox_Account.IconIsButton = false;
			this.textBox_Account.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_Account.IsPasswordChat = '\0';
			this.textBox_Account.IsSystemPasswordChar = false;
			this.textBox_Account.Lines = new string[0];
			this.textBox_Account.Location = new System.Drawing.Point(107, 162);
			this.textBox_Account.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_Account.MaxLength = 20;
			this.textBox_Account.MinimumSize = new System.Drawing.Size(28, 28);
			this.textBox_Account.MouseBack = null;
			this.textBox_Account.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_Account.Multiline = true;
			this.textBox_Account.Name = "textBox_Account";
			this.textBox_Account.NormlBack = null;
			this.textBox_Account.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
			this.textBox_Account.ReadOnly = false;
			this.textBox_Account.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.textBox_Account.Size = new System.Drawing.Size(229, 32);
			// 
			// 
			// 
			this.textBox_Account.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_Account.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_Account.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.textBox_Account.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.textBox_Account.SkinTxt.MaxLength = 20;
			this.textBox_Account.SkinTxt.Multiline = true;
			this.textBox_Account.SkinTxt.Name = "BaseText";
			this.textBox_Account.SkinTxt.Size = new System.Drawing.Size(196, 22);
			this.textBox_Account.SkinTxt.TabIndex = 0;
			this.textBox_Account.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_Account.SkinTxt.WaterText = "请输入您的帐号";
			this.textBox_Account.TabIndex = 1;
			this.textBox_Account.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.textBox_Account.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_Account.WaterText = "请输入您的帐号";
			this.textBox_Account.WordWrap = true;
			// 
			// textBox_Passwd
			// 
			this.textBox_Passwd.BackColor = System.Drawing.Color.Transparent;
			this.textBox_Passwd.DownBack = null;
			this.textBox_Passwd.Icon = global::CashBook.Properties.Resources.password;
			this.textBox_Passwd.IconIsButton = false;
			this.textBox_Passwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_Passwd.IsPasswordChat = '●';
			this.textBox_Passwd.IsSystemPasswordChar = false;
			this.textBox_Passwd.Lines = new string[0];
			this.textBox_Passwd.Location = new System.Drawing.Point(107, 204);
			this.textBox_Passwd.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_Passwd.MaxLength = 20;
			this.textBox_Passwd.MinimumSize = new System.Drawing.Size(28, 28);
			this.textBox_Passwd.MouseBack = null;
			this.textBox_Passwd.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_Passwd.Multiline = true;
			this.textBox_Passwd.Name = "textBox_Passwd";
			this.textBox_Passwd.NormlBack = null;
			this.textBox_Passwd.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
			this.textBox_Passwd.ReadOnly = false;
			this.textBox_Passwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.textBox_Passwd.Size = new System.Drawing.Size(229, 32);
			// 
			// 
			// 
			this.textBox_Passwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_Passwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_Passwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.textBox_Passwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.textBox_Passwd.SkinTxt.MaxLength = 20;
			this.textBox_Passwd.SkinTxt.Multiline = true;
			this.textBox_Passwd.SkinTxt.Name = "BaseText";
			this.textBox_Passwd.SkinTxt.PasswordChar = '●';
			this.textBox_Passwd.SkinTxt.Size = new System.Drawing.Size(196, 22);
			this.textBox_Passwd.SkinTxt.TabIndex = 0;
			this.textBox_Passwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_Passwd.SkinTxt.WaterText = "请输入您的密码";
			this.textBox_Passwd.TabIndex = 2;
			this.textBox_Passwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.textBox_Passwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_Passwd.WaterText = "请输入您的密码";
			this.textBox_Passwd.WordWrap = true;
			// 
			// Btn_Login
			// 
			this.Btn_Login.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Login.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
			this.Btn_Login.BorderColor = System.Drawing.Color.Empty;
			this.Btn_Login.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.Btn_Login.DownBack = null;
			this.Btn_Login.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(189)))), ((int)(((byte)(253)))));
			this.Btn_Login.FadeGlow = false;
			this.Btn_Login.Font = new System.Drawing.Font("微软雅黑", 10F);
			this.Btn_Login.ForeColor = System.Drawing.Color.White;
			this.Btn_Login.GlowColor = System.Drawing.Color.Empty;
			this.Btn_Login.InnerBorderColor = System.Drawing.Color.Empty;
			this.Btn_Login.IsDrawGlass = false;
			this.Btn_Login.Location = new System.Drawing.Point(107, 269);
			this.Btn_Login.MouseBack = null;
			this.Btn_Login.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(134)))), ((int)(((byte)(253)))));
			this.Btn_Login.Name = "Btn_Login";
			this.Btn_Login.NormlBack = null;
			this.Btn_Login.Radius = 4;
			this.Btn_Login.RoundStyle = CCWin.SkinClass.RoundStyle.All;
			this.Btn_Login.Size = new System.Drawing.Size(229, 32);
			this.Btn_Login.TabIndex = 0;
			this.Btn_Login.Text = "登录";
			this.Btn_Login.UseVisualStyleBackColor = false;
			this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
			// 
			// linkLabel_RegAccount
			// 
			this.linkLabel_RegAccount.AutoSize = true;
			this.linkLabel_RegAccount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.linkLabel_RegAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.linkLabel_RegAccount.LinkColor = System.Drawing.SystemColors.GrayText;
			this.linkLabel_RegAccount.Location = new System.Drawing.Point(107, 244);
			this.linkLabel_RegAccount.Name = "linkLabel_RegAccount";
			this.linkLabel_RegAccount.Size = new System.Drawing.Size(56, 17);
			this.linkLabel_RegAccount.TabIndex = 3;
			this.linkLabel_RegAccount.TabStop = true;
			this.linkLabel_RegAccount.Text = "注册帐号";
			this.linkLabel_RegAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_RegAccount_LinkClicked);
			// 
			// linkLabel_ForgetPasswd
			// 
			this.linkLabel_ForgetPasswd.AutoSize = true;
			this.linkLabel_ForgetPasswd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.linkLabel_ForgetPasswd.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.linkLabel_ForgetPasswd.LinkColor = System.Drawing.SystemColors.GrayText;
			this.linkLabel_ForgetPasswd.Location = new System.Drawing.Point(274, 244);
			this.linkLabel_ForgetPasswd.Name = "linkLabel_ForgetPasswd";
			this.linkLabel_ForgetPasswd.Size = new System.Drawing.Size(68, 17);
			this.linkLabel_ForgetPasswd.TabIndex = 4;
			this.linkLabel_ForgetPasswd.TabStop = true;
			this.linkLabel_ForgetPasswd.Text = "忘记密码？";
			this.linkLabel_ForgetPasswd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ForgetPasswd_LinkClicked);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::CashBook.Properties.Resources.LoginBG;
			this.pictureBox1.Location = new System.Drawing.Point(1, 32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(440, 115);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// FormLogin
			// 
			this.AcceptButton = this.Btn_Login;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(95)))), ((int)(((byte)(205)))));
			this.CaptionBackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
			this.CaptionBackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
			this.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
			this.ClientSize = new System.Drawing.Size(442, 315);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.linkLabel_ForgetPasswd);
			this.Controls.Add(this.linkLabel_RegAccount);
			this.Controls.Add(this.Btn_Login);
			this.Controls.Add(this.textBox_Passwd);
			this.Controls.Add(this.textBox_Account);
			this.EffectBack = System.Drawing.Color.Black;
			this.EffectWidth = 5;
			this.Font = new System.Drawing.Font("宋体", 9F);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.InnerBorderColor = System.Drawing.Color.Empty;
			this.MaximizeBox = false;
			this.Name = "FormLogin";
			this.Radius = 3;
			this.Text = "小白兔记账本 • 登录";
			this.TitleCenter = false;
			this.TitleColor = System.Drawing.Color.White;
			this.TitleOffset = new System.Drawing.Point(0, 4);
			this.Load += new System.EventHandler(this.FormLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CCWin.SkinControl.SkinTextBox textBox_Account;
		private CCWin.SkinControl.SkinTextBox textBox_Passwd;
		private CCWin.SkinControl.SkinButton Btn_Login;
		private System.Windows.Forms.LinkLabel linkLabel_RegAccount;
		private System.Windows.Forms.LinkLabel linkLabel_ForgetPasswd;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

