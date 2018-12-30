namespace CashBook
{
	partial class FormAbount
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbount));
			this.Btn_OK = new CCWin.SkinControl.SkinButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
			this.skinLabel_About = new CCWin.SkinControl.SkinLabel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// Btn_OK
			// 
			this.Btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Btn_OK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
			this.Btn_OK.BorderColor = System.Drawing.Color.Empty;
			this.Btn_OK.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.Btn_OK.DownBack = null;
			this.Btn_OK.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(189)))), ((int)(((byte)(253)))));
			this.Btn_OK.FadeGlow = false;
			this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.Btn_OK.ForeColor = System.Drawing.Color.White;
			this.Btn_OK.GlowColor = System.Drawing.Color.Empty;
			this.Btn_OK.InnerBorderColor = System.Drawing.Color.Empty;
			this.Btn_OK.IsDrawGlass = false;
			this.Btn_OK.Location = new System.Drawing.Point(339, 193);
			this.Btn_OK.MouseBack = null;
			this.Btn_OK.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(134)))), ((int)(((byte)(253)))));
			this.Btn_OK.Name = "Btn_OK";
			this.Btn_OK.NormlBack = null;
			this.Btn_OK.Radius = 4;
			this.Btn_OK.RoundStyle = CCWin.SkinClass.RoundStyle.All;
			this.Btn_OK.Size = new System.Drawing.Size(77, 27);
			this.Btn_OK.TabIndex = 16;
			this.Btn_OK.Text = "确定";
			this.Btn_OK.UseVisualStyleBackColor = false;
			this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(15, 109);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(60, 60);
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// skinLabel1
			// 
			this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
			this.skinLabel1.AutoSize = true;
			this.skinLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.skinLabel1.BorderColor = System.Drawing.Color.Empty;
			this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.skinLabel1.Location = new System.Drawing.Point(96, 148);
			this.skinLabel1.Name = "skinLabel1";
			this.skinLabel1.Size = new System.Drawing.Size(256, 17);
			this.skinLabel1.TabIndex = 18;
			this.skinLabel1.Text = "这是一款免费软件，版权归作者 小白兔 所有。";
			// 
			// skinLabel_About
			// 
			this.skinLabel_About.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
			this.skinLabel_About.AutoSize = true;
			this.skinLabel_About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.skinLabel_About.BorderColor = System.Drawing.Color.Empty;
			this.skinLabel_About.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.skinLabel_About.Location = new System.Drawing.Point(96, 128);
			this.skinLabel_About.Name = "skinLabel_About";
			this.skinLabel_About.Size = new System.Drawing.Size(104, 17);
			this.skinLabel_About.TabIndex = 19;
			this.skinLabel_About.Text = "此处显示版本信息";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.pictureBox2.Image = global::CashBook.Properties.Resources.AboutBG;
			this.pictureBox2.Location = new System.Drawing.Point(1, 32);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(421, 71);
			this.pictureBox2.TabIndex = 20;
			this.pictureBox2.TabStop = false;
			// 
			// skinPanel1
			// 
			this.skinPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.skinPanel1.DownBack = null;
			this.skinPanel1.Location = new System.Drawing.Point(1, 32);
			this.skinPanel1.MouseBack = null;
			this.skinPanel1.Name = "skinPanel1";
			this.skinPanel1.NormlBack = null;
			this.skinPanel1.Size = new System.Drawing.Size(420, 193);
			this.skinPanel1.TabIndex = 21;
			// 
			// FormAbount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(95)))), ((int)(((byte)(205)))));
			this.CaptionFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ClientSize = new System.Drawing.Size(423, 227);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.skinLabel_About);
			this.Controls.Add(this.skinLabel1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Btn_OK);
			this.Controls.Add(this.skinPanel1);
			this.EffectBack = System.Drawing.Color.Black;
			this.EffectWidth = 5;
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.InnerBorderColor = System.Drawing.Color.Empty;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAbount";
			this.Radius = 3;
			this.ShowDrawIcon = false;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "关于 小白兔记账本";
			this.TitleCenter = false;
			this.TitleColor = System.Drawing.Color.White;
			this.TitleOffset = new System.Drawing.Point(0, 0);
			this.Load += new System.EventHandler(this.FormAbount_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CCWin.SkinControl.SkinButton Btn_OK;
		private System.Windows.Forms.PictureBox pictureBox1;
		private CCWin.SkinControl.SkinLabel skinLabel1;
		private CCWin.SkinControl.SkinLabel skinLabel_About;
		private System.Windows.Forms.PictureBox pictureBox2;
		private CCWin.SkinControl.SkinPanel skinPanel1;
	}
}