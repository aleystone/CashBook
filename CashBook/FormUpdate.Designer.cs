namespace CashBook
{
	partial class FormUpdate
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
			this.textBox_UpdateLog = new System.Windows.Forms.TextBox();
			this.Btn_Update = new CCWin.SkinControl.SkinButton();
			this.label1 = new System.Windows.Forms.Label();
			this.linkLabel_FeedBack = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
			this.SuspendLayout();
			// 
			// textBox_UpdateLog
			// 
			this.textBox_UpdateLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
			this.textBox_UpdateLog.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.textBox_UpdateLog.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.textBox_UpdateLog.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.textBox_UpdateLog.Location = new System.Drawing.Point(12, 56);
			this.textBox_UpdateLog.Multiline = true;
			this.textBox_UpdateLog.Name = "textBox_UpdateLog";
			this.textBox_UpdateLog.ReadOnly = true;
			this.textBox_UpdateLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_UpdateLog.Size = new System.Drawing.Size(426, 419);
			this.textBox_UpdateLog.TabIndex = 1;
			// 
			// Btn_Update
			// 
			this.Btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Btn_Update.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
			this.Btn_Update.BorderColor = System.Drawing.Color.Empty;
			this.Btn_Update.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.Btn_Update.DownBack = null;
			this.Btn_Update.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(189)))), ((int)(((byte)(253)))));
			this.Btn_Update.FadeGlow = false;
			this.Btn_Update.Font = new System.Drawing.Font("微软雅黑", 10F);
			this.Btn_Update.ForeColor = System.Drawing.Color.White;
			this.Btn_Update.InnerBorderColor = System.Drawing.Color.Empty;
			this.Btn_Update.IsDrawGlass = false;
			this.Btn_Update.Location = new System.Drawing.Point(157, 481);
			this.Btn_Update.MouseBack = null;
			this.Btn_Update.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(134)))), ((int)(((byte)(253)))));
			this.Btn_Update.Name = "Btn_Update";
			this.Btn_Update.NormlBack = null;
			this.Btn_Update.Radius = 15;
			this.Btn_Update.RoundStyle = CCWin.SkinClass.RoundStyle.All;
			this.Btn_Update.Size = new System.Drawing.Size(139, 39);
			this.Btn_Update.TabIndex = 0;
			this.Btn_Update.Text = "检查更新";
			this.Btn_Update.UseVisualStyleBackColor = false;
			this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(9, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "日志记录：";
			// 
			// linkLabel_FeedBack
			// 
			this.linkLabel_FeedBack.AutoSize = true;
			this.linkLabel_FeedBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.linkLabel_FeedBack.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.linkLabel_FeedBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.linkLabel_FeedBack.Location = new System.Drawing.Point(384, 34);
			this.linkLabel_FeedBack.Name = "linkLabel_FeedBack";
			this.linkLabel_FeedBack.Size = new System.Drawing.Size(56, 17);
			this.linkLabel_FeedBack.TabIndex = 3;
			this.linkLabel_FeedBack.TabStop = true;
			this.linkLabel_FeedBack.Text = "意见反馈";
			this.linkLabel_FeedBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_FeedBack_LinkClicked);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.linkLabel1.LinkColor = System.Drawing.Color.DarkSlateGray;
			this.linkLabel1.Location = new System.Drawing.Point(376, 502);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(56, 17);
			this.linkLabel1.TabIndex = 2;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "暂不更新";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// skinPanel1
			// 
			this.skinPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.skinPanel1.DownBack = null;
			this.skinPanel1.Location = new System.Drawing.Point(1, 33);
			this.skinPanel1.MouseBack = null;
			this.skinPanel1.Name = "skinPanel1";
			this.skinPanel1.NormlBack = null;
			this.skinPanel1.Size = new System.Drawing.Size(447, 492);
			this.skinPanel1.TabIndex = 8;
			// 
			// FormUpdate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.CaptionFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ClientSize = new System.Drawing.Size(450, 527);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.linkLabel_FeedBack);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Btn_Update);
			this.Controls.Add(this.textBox_UpdateLog);
			this.Controls.Add(this.skinPanel1);
			this.EffectBack = System.Drawing.Color.Black;
			this.EffectWidth = 5;
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormUpdate";
			this.Radius = 3;
			this.ShowDrawIcon = false;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "检测更新";
			this.TitleCenter = false;
			this.TitleColor = System.Drawing.Color.White;
			this.TitleOffset = new System.Drawing.Point(0, 0);
			this.Load += new System.EventHandler(this.FormUpdate_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_UpdateLog;
		private CCWin.SkinControl.SkinButton Btn_Update;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel linkLabel_FeedBack;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private CCWin.SkinControl.SkinPanel skinPanel1;
	}
}