namespace CashBook
{
	partial class FormForgetPassword
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgetPassword));
			this.label_MAcc = new CCWin.SkinControl.SkinLabel();
			this.label_MEmail = new CCWin.SkinControl.SkinLabel();
			this.label_MNewPasswd1 = new CCWin.SkinControl.SkinLabel();
			this.labelMNewPasswd2 = new CCWin.SkinControl.SkinLabel();
			this.textBox_ModifyAcc = new CCWin.SkinControl.SkinTextBox();
			this.textBox_ModifyEmail = new CCWin.SkinControl.SkinTextBox();
			this.textBox_ModifyPasswd1 = new CCWin.SkinControl.SkinTextBox();
			this.textBox_ModifyPasswd2 = new CCWin.SkinControl.SkinTextBox();
			this.Btn_ModifyPassword = new CCWin.SkinControl.SkinButton();
			this.Btn_Cancel = new CCWin.SkinControl.SkinButton();
			this.SuspendLayout();
			// 
			// label_MAcc
			// 
			this.label_MAcc.AutoSize = true;
			this.label_MAcc.BackColor = System.Drawing.Color.Transparent;
			this.label_MAcc.BorderColor = System.Drawing.Color.White;
			this.label_MAcc.Font = new System.Drawing.Font("微软雅黑", 10F);
			this.label_MAcc.Location = new System.Drawing.Point(29, 68);
			this.label_MAcc.Name = "label_MAcc";
			this.label_MAcc.Size = new System.Drawing.Size(79, 20);
			this.label_MAcc.TabIndex = 0;
			this.label_MAcc.Text = "帐       号：";
			// 
			// label_MEmail
			// 
			this.label_MEmail.AutoSize = true;
			this.label_MEmail.BackColor = System.Drawing.Color.Transparent;
			this.label_MEmail.BorderColor = System.Drawing.Color.White;
			this.label_MEmail.Font = new System.Drawing.Font("微软雅黑", 10F);
			this.label_MEmail.Location = new System.Drawing.Point(29, 115);
			this.label_MEmail.Name = "label_MEmail";
			this.label_MEmail.Size = new System.Drawing.Size(79, 20);
			this.label_MEmail.TabIndex = 1;
			this.label_MEmail.Text = "电子邮箱：";
			// 
			// label_MNewPasswd1
			// 
			this.label_MNewPasswd1.AutoSize = true;
			this.label_MNewPasswd1.BackColor = System.Drawing.Color.Transparent;
			this.label_MNewPasswd1.BorderColor = System.Drawing.Color.White;
			this.label_MNewPasswd1.Font = new System.Drawing.Font("微软雅黑", 10F);
			this.label_MNewPasswd1.Location = new System.Drawing.Point(27, 162);
			this.label_MNewPasswd1.Name = "label_MNewPasswd1";
			this.label_MNewPasswd1.Size = new System.Drawing.Size(81, 20);
			this.label_MNewPasswd1.TabIndex = 2;
			this.label_MNewPasswd1.Text = "新  密  码：";
			// 
			// labelMNewPasswd2
			// 
			this.labelMNewPasswd2.AutoSize = true;
			this.labelMNewPasswd2.BackColor = System.Drawing.Color.Transparent;
			this.labelMNewPasswd2.BorderColor = System.Drawing.Color.White;
			this.labelMNewPasswd2.Font = new System.Drawing.Font("微软雅黑", 10F);
			this.labelMNewPasswd2.Location = new System.Drawing.Point(29, 209);
			this.labelMNewPasswd2.Name = "labelMNewPasswd2";
			this.labelMNewPasswd2.Size = new System.Drawing.Size(79, 20);
			this.labelMNewPasswd2.TabIndex = 3;
			this.labelMNewPasswd2.Text = "确认密码：";
			// 
			// textBox_ModifyAcc
			// 
			this.textBox_ModifyAcc.BackColor = System.Drawing.Color.Transparent;
			this.textBox_ModifyAcc.DownBack = null;
			this.textBox_ModifyAcc.Icon = null;
			this.textBox_ModifyAcc.IconIsButton = false;
			this.textBox_ModifyAcc.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_ModifyAcc.IsPasswordChat = '\0';
			this.textBox_ModifyAcc.IsSystemPasswordChar = false;
			this.textBox_ModifyAcc.Lines = new string[0];
			this.textBox_ModifyAcc.Location = new System.Drawing.Point(113, 64);
			this.textBox_ModifyAcc.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_ModifyAcc.MaxLength = 20;
			this.textBox_ModifyAcc.MinimumSize = new System.Drawing.Size(28, 28);
			this.textBox_ModifyAcc.MouseBack = null;
			this.textBox_ModifyAcc.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_ModifyAcc.Multiline = false;
			this.textBox_ModifyAcc.Name = "textBox_ModifyAcc";
			this.textBox_ModifyAcc.NormlBack = null;
			this.textBox_ModifyAcc.Padding = new System.Windows.Forms.Padding(5);
			this.textBox_ModifyAcc.ReadOnly = false;
			this.textBox_ModifyAcc.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.textBox_ModifyAcc.Size = new System.Drawing.Size(185, 28);
			// 
			// 
			// 
			this.textBox_ModifyAcc.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_ModifyAcc.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_ModifyAcc.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.textBox_ModifyAcc.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.textBox_ModifyAcc.SkinTxt.MaxLength = 20;
			this.textBox_ModifyAcc.SkinTxt.Name = "BaseText";
			this.textBox_ModifyAcc.SkinTxt.Size = new System.Drawing.Size(175, 18);
			this.textBox_ModifyAcc.SkinTxt.TabIndex = 0;
			this.textBox_ModifyAcc.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_ModifyAcc.SkinTxt.WaterText = "";
			this.textBox_ModifyAcc.TabIndex = 0;
			this.textBox_ModifyAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.textBox_ModifyAcc.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_ModifyAcc.WaterText = "";
			this.textBox_ModifyAcc.WordWrap = true;
			// 
			// textBox_ModifyEmail
			// 
			this.textBox_ModifyEmail.BackColor = System.Drawing.Color.Transparent;
			this.textBox_ModifyEmail.DownBack = null;
			this.textBox_ModifyEmail.Icon = null;
			this.textBox_ModifyEmail.IconIsButton = false;
			this.textBox_ModifyEmail.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_ModifyEmail.IsPasswordChat = '\0';
			this.textBox_ModifyEmail.IsSystemPasswordChar = false;
			this.textBox_ModifyEmail.Lines = new string[0];
			this.textBox_ModifyEmail.Location = new System.Drawing.Point(113, 111);
			this.textBox_ModifyEmail.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_ModifyEmail.MaxLength = 40;
			this.textBox_ModifyEmail.MinimumSize = new System.Drawing.Size(28, 28);
			this.textBox_ModifyEmail.MouseBack = null;
			this.textBox_ModifyEmail.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_ModifyEmail.Multiline = false;
			this.textBox_ModifyEmail.Name = "textBox_ModifyEmail";
			this.textBox_ModifyEmail.NormlBack = null;
			this.textBox_ModifyEmail.Padding = new System.Windows.Forms.Padding(5);
			this.textBox_ModifyEmail.ReadOnly = false;
			this.textBox_ModifyEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.textBox_ModifyEmail.Size = new System.Drawing.Size(185, 28);
			// 
			// 
			// 
			this.textBox_ModifyEmail.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_ModifyEmail.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_ModifyEmail.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.textBox_ModifyEmail.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.textBox_ModifyEmail.SkinTxt.MaxLength = 40;
			this.textBox_ModifyEmail.SkinTxt.Name = "BaseText";
			this.textBox_ModifyEmail.SkinTxt.Size = new System.Drawing.Size(175, 18);
			this.textBox_ModifyEmail.SkinTxt.TabIndex = 0;
			this.textBox_ModifyEmail.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_ModifyEmail.SkinTxt.WaterText = "";
			this.textBox_ModifyEmail.TabIndex = 1;
			this.textBox_ModifyEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.textBox_ModifyEmail.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_ModifyEmail.WaterText = "";
			this.textBox_ModifyEmail.WordWrap = true;
			// 
			// textBox_ModifyPasswd1
			// 
			this.textBox_ModifyPasswd1.BackColor = System.Drawing.Color.Transparent;
			this.textBox_ModifyPasswd1.DownBack = null;
			this.textBox_ModifyPasswd1.Icon = null;
			this.textBox_ModifyPasswd1.IconIsButton = false;
			this.textBox_ModifyPasswd1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_ModifyPasswd1.IsPasswordChat = '●';
			this.textBox_ModifyPasswd1.IsSystemPasswordChar = true;
			this.textBox_ModifyPasswd1.Lines = new string[0];
			this.textBox_ModifyPasswd1.Location = new System.Drawing.Point(113, 158);
			this.textBox_ModifyPasswd1.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_ModifyPasswd1.MaxLength = 20;
			this.textBox_ModifyPasswd1.MinimumSize = new System.Drawing.Size(28, 28);
			this.textBox_ModifyPasswd1.MouseBack = null;
			this.textBox_ModifyPasswd1.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_ModifyPasswd1.Multiline = false;
			this.textBox_ModifyPasswd1.Name = "textBox_ModifyPasswd1";
			this.textBox_ModifyPasswd1.NormlBack = null;
			this.textBox_ModifyPasswd1.Padding = new System.Windows.Forms.Padding(5);
			this.textBox_ModifyPasswd1.ReadOnly = false;
			this.textBox_ModifyPasswd1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.textBox_ModifyPasswd1.Size = new System.Drawing.Size(185, 28);
			// 
			// 
			// 
			this.textBox_ModifyPasswd1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_ModifyPasswd1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_ModifyPasswd1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.textBox_ModifyPasswd1.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.textBox_ModifyPasswd1.SkinTxt.MaxLength = 20;
			this.textBox_ModifyPasswd1.SkinTxt.Name = "BaseText";
			this.textBox_ModifyPasswd1.SkinTxt.PasswordChar = '●';
			this.textBox_ModifyPasswd1.SkinTxt.Size = new System.Drawing.Size(175, 18);
			this.textBox_ModifyPasswd1.SkinTxt.TabIndex = 0;
			this.textBox_ModifyPasswd1.SkinTxt.UseSystemPasswordChar = true;
			this.textBox_ModifyPasswd1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_ModifyPasswd1.SkinTxt.WaterText = "";
			this.textBox_ModifyPasswd1.TabIndex = 2;
			this.textBox_ModifyPasswd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.textBox_ModifyPasswd1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_ModifyPasswd1.WaterText = "";
			this.textBox_ModifyPasswd1.WordWrap = true;
			// 
			// textBox_ModifyPasswd2
			// 
			this.textBox_ModifyPasswd2.BackColor = System.Drawing.Color.Transparent;
			this.textBox_ModifyPasswd2.DownBack = null;
			this.textBox_ModifyPasswd2.Icon = null;
			this.textBox_ModifyPasswd2.IconIsButton = false;
			this.textBox_ModifyPasswd2.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_ModifyPasswd2.IsPasswordChat = '●';
			this.textBox_ModifyPasswd2.IsSystemPasswordChar = true;
			this.textBox_ModifyPasswd2.Lines = new string[0];
			this.textBox_ModifyPasswd2.Location = new System.Drawing.Point(113, 205);
			this.textBox_ModifyPasswd2.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_ModifyPasswd2.MaxLength = 20;
			this.textBox_ModifyPasswd2.MinimumSize = new System.Drawing.Size(28, 28);
			this.textBox_ModifyPasswd2.MouseBack = null;
			this.textBox_ModifyPasswd2.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.textBox_ModifyPasswd2.Multiline = false;
			this.textBox_ModifyPasswd2.Name = "textBox_ModifyPasswd2";
			this.textBox_ModifyPasswd2.NormlBack = null;
			this.textBox_ModifyPasswd2.Padding = new System.Windows.Forms.Padding(5);
			this.textBox_ModifyPasswd2.ReadOnly = false;
			this.textBox_ModifyPasswd2.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.textBox_ModifyPasswd2.Size = new System.Drawing.Size(185, 28);
			// 
			// 
			// 
			this.textBox_ModifyPasswd2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_ModifyPasswd2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_ModifyPasswd2.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.textBox_ModifyPasswd2.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.textBox_ModifyPasswd2.SkinTxt.MaxLength = 20;
			this.textBox_ModifyPasswd2.SkinTxt.Name = "BaseText";
			this.textBox_ModifyPasswd2.SkinTxt.PasswordChar = '●';
			this.textBox_ModifyPasswd2.SkinTxt.Size = new System.Drawing.Size(175, 18);
			this.textBox_ModifyPasswd2.SkinTxt.TabIndex = 0;
			this.textBox_ModifyPasswd2.SkinTxt.UseSystemPasswordChar = true;
			this.textBox_ModifyPasswd2.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_ModifyPasswd2.SkinTxt.WaterText = "";
			this.textBox_ModifyPasswd2.TabIndex = 3;
			this.textBox_ModifyPasswd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.textBox_ModifyPasswd2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.textBox_ModifyPasswd2.WaterText = "";
			this.textBox_ModifyPasswd2.WordWrap = true;
			// 
			// Btn_ModifyPassword
			// 
			this.Btn_ModifyPassword.BackColor = System.Drawing.Color.Transparent;
			this.Btn_ModifyPassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
			this.Btn_ModifyPassword.BorderColor = System.Drawing.Color.Empty;
			this.Btn_ModifyPassword.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.Btn_ModifyPassword.DownBack = null;
			this.Btn_ModifyPassword.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(189)))), ((int)(((byte)(253)))));
			this.Btn_ModifyPassword.FadeGlow = false;
			this.Btn_ModifyPassword.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.Btn_ModifyPassword.ForeColor = System.Drawing.Color.White;
			this.Btn_ModifyPassword.InnerBorderColor = System.Drawing.Color.Empty;
			this.Btn_ModifyPassword.IsDrawGlass = false;
			this.Btn_ModifyPassword.Location = new System.Drawing.Point(40, 295);
			this.Btn_ModifyPassword.MouseBack = null;
			this.Btn_ModifyPassword.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(134)))), ((int)(((byte)(253)))));
			this.Btn_ModifyPassword.Name = "Btn_ModifyPassword";
			this.Btn_ModifyPassword.NormlBack = null;
			this.Btn_ModifyPassword.Radius = 4;
			this.Btn_ModifyPassword.RoundStyle = CCWin.SkinClass.RoundStyle.All;
			this.Btn_ModifyPassword.Size = new System.Drawing.Size(75, 29);
			this.Btn_ModifyPassword.TabIndex = 4;
			this.Btn_ModifyPassword.Text = "保存修改";
			this.Btn_ModifyPassword.UseVisualStyleBackColor = false;
			this.Btn_ModifyPassword.Click += new System.EventHandler(this.Btn_ModifyPassword_Click);
			// 
			// Btn_Cancel
			// 
			this.Btn_Cancel.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Cancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
			this.Btn_Cancel.BorderColor = System.Drawing.Color.Empty;
			this.Btn_Cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.Btn_Cancel.DownBack = null;
			this.Btn_Cancel.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(189)))), ((int)(((byte)(253)))));
			this.Btn_Cancel.FadeGlow = false;
			this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Btn_Cancel.ForeColor = System.Drawing.Color.White;
			this.Btn_Cancel.InnerBorderColor = System.Drawing.Color.Empty;
			this.Btn_Cancel.IsDrawGlass = false;
			this.Btn_Cancel.Location = new System.Drawing.Point(209, 295);
			this.Btn_Cancel.MouseBack = null;
			this.Btn_Cancel.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(134)))), ((int)(((byte)(253)))));
			this.Btn_Cancel.Name = "Btn_Cancel";
			this.Btn_Cancel.NormlBack = null;
			this.Btn_Cancel.Radius = 4;
			this.Btn_Cancel.RoundStyle = CCWin.SkinClass.RoundStyle.All;
			this.Btn_Cancel.Size = new System.Drawing.Size(75, 29);
			this.Btn_Cancel.TabIndex = 5;
			this.Btn_Cancel.Text = "取消";
			this.Btn_Cancel.UseVisualStyleBackColor = false;
			this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
			// 
			// FormForgetPassword
			// 
			this.AcceptButton = this.Btn_ModifyPassword;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(95)))), ((int)(((byte)(205)))));
			this.CaptionBackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
			this.CaptionBackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
			this.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
			this.ClientSize = new System.Drawing.Size(325, 359);
			this.Controls.Add(this.Btn_Cancel);
			this.Controls.Add(this.Btn_ModifyPassword);
			this.Controls.Add(this.textBox_ModifyPasswd2);
			this.Controls.Add(this.textBox_ModifyPasswd1);
			this.Controls.Add(this.textBox_ModifyEmail);
			this.Controls.Add(this.textBox_ModifyAcc);
			this.Controls.Add(this.labelMNewPasswd2);
			this.Controls.Add(this.label_MNewPasswd1);
			this.Controls.Add(this.label_MEmail);
			this.Controls.Add(this.label_MAcc);
			this.EffectBack = System.Drawing.Color.Black;
			this.EffectWidth = 5;
			this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.InnerBorderColor = System.Drawing.Color.Empty;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormForgetPassword";
			this.Radius = 3;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "小白兔记账本 • 忘记密码";
			this.TitleCenter = false;
			this.TitleColor = System.Drawing.Color.White;
			this.TitleOffset = new System.Drawing.Point(0, 4);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CCWin.SkinControl.SkinLabel label_MAcc;
		private CCWin.SkinControl.SkinLabel label_MEmail;
		private CCWin.SkinControl.SkinLabel label_MNewPasswd1;
		private CCWin.SkinControl.SkinLabel labelMNewPasswd2;
		private CCWin.SkinControl.SkinTextBox textBox_ModifyAcc;
		private CCWin.SkinControl.SkinTextBox textBox_ModifyEmail;
		private CCWin.SkinControl.SkinTextBox textBox_ModifyPasswd1;
		private CCWin.SkinControl.SkinTextBox textBox_ModifyPasswd2;
		private CCWin.SkinControl.SkinButton Btn_ModifyPassword;
		private CCWin.SkinControl.SkinButton Btn_Cancel;
	}
}