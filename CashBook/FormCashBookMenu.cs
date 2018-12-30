using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using CCWin;

namespace CashBook
{
	public partial class FormCashBookMenu : Skin_Mac
	{
		private SQLiteOperate objConn = new SQLiteOperate();
		private FormLogin objFCBook = new FormLogin();
		public static string TableCashBookInfo = string.Empty;
		FormLogin frm = new FormLogin();
		private string sql_getUID = string.Empty;
		private string sql_create_t_cashbook_info = string.Empty;
		string[] UID = new string[1];
		// 定时器
		System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

		public FormCashBookMenu()
		{
			InitializeComponent();
			objConn.CreateSqliteDBFile();	// 创建数据库文件
			objConn.ConnectionToSqliteDB(); // 连接数据库
			sql_getUID = string.Format("select uid from t_users where acc='{0}'", frm.GetAccount());
			objConn.SelectDataFromSqlite(sql_getUID, UID, 1);
			TableCashBookInfo = string.Format("t_cashbook_info_{0}", UID[0]);
			sql_create_t_cashbook_info = string.Format("CREATE TABLE {0} (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,UID INTEGER NOT NULL,DateTime TEXT(20) NOT NULL,TallyType TEXT(50) NOT NULL,BudgetType TEXT(50) NOT NULL,Amount INTEGER NOT NULL,InOutProject TEXT(50) NOT NULL,Income DOUBLE NOT NULL DEFAULT 0.00,PayOut DOUBLE NOT NULL DEFAULT 0.00,Total DOUBLE NOT NULL DEFAULT 0.00,PayMode TEXT(20) NOT NULL,RecordUser TEXT(20) NOT NULL,Remark TEXT)", TableCashBookInfo);
			// 建用户数据表t_cashbook_info
			objConn.CreateTableToSqlite(TableCashBookInfo, sql_create_t_cashbook_info);	
		
			SetWindowsFormTitle();	// 设置窗体标题
			// 将用书设置的皮肤保存至配置文件中
			string skinName = CashBookConfig.GetAppConfig("Skin");
			if (string.IsNullOrEmpty(skinName))
			{
				CashBookConfig.UpdateAppConfig("Skin", "DefaultSkin");
			}
			SetStyles();
		}

		private void StartTimer()
		{
			myTimer.Tick += new EventHandler(Callback);
			myTimer.Enabled = true;
			myTimer.Interval = 1000;	// 1000ms=1s
		}
		// 委托事件
		private void Callback(object sender, EventArgs e)
		{
			this.toolStripStatusLabel_DateTime.Text = "登录时间:" + DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]");
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

		public static List<string> DataList = new List<string>(); 
		public List<string> GetDataFromListView()
		{
			if (DataList.Count == 0)
			{
				for (int i = 0; i < listView_ShowData.SelectedItems.Count; i++)
				{
					for (int j = 0; j < listView_ShowData.Columns.Count; j++)
					{
						DataList.Add(listView_ShowData.SelectedItems[i].SubItems[j].Text);
					}
				}
				
			}
			return DataList;
		}

		public string GetFrmTitle()
		{
			return frmModifyTitle;
		}

		#region 设置窗体标题
		// 设置窗体标题
		private void SetWindowsFormTitle()
		{
// 			System.DateTime currTime = new System.DateTime();
// 			currTime = System.DateTime.Now;
// 			string m_Year = currTime.ToString("yyyy");
// 			string m_Month = currTime.ToString("MM");
// 			string m_Day = currTime.ToString("dd");
// 			string m_Week = currTime.ToString("ddd");
// 			string strDateTime = string.Format("今天是{0}年{1}月{2}日 {3}", m_Year, m_Month, m_Day, m_Week);
			this.Text = "小白兔记账本         " + string.Format("      欢迎您！{0}", objFCBook.GetUserName());
		}
		#endregion

		// 获取版本号
		public string GetVersion(string mVer)
		{
			var version = Assembly.GetExecutingAssembly().GetName().Version;
			string mainVersion = "";
			if (mVer.Equals("mainVer"))
			{
				string[] MainVersion = version.ToString().Split(new char[] { '.' });
				mainVersion = MainVersion[0] + "." + MainVersion[1] + "." + MainVersion[2];
			}
			return mainVersion;
		}

		public string GetVersion()
		{
			return Assembly.GetExecutingAssembly().GetName().Version.ToString();
		}

		private void FormCashBookMenu_Load(object sender, EventArgs e)
		{
			this.toolStripStatusLabel_DateTime.Text = "登录时间:" + DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]");
			// 启动定时器
			StartTimer();
			// 状态栏显示信息
			this.comboBox_Type.SelectedIndex = 1;	// comboBox默认选择第一项
			this.radioButton_Vague.Checked = true;	// radiobutton默认选中项
			listShowData();	// 显示数据

			// 从App.config中读取皮肤配置
			string skinName = CashBookConfig.GetAppConfig("Skin");
			switch (skinName)
			{
				case "DefaultSkin": // 默认皮肤
					if (!toolStripMenuItem_Default.Checked){ toolStripMenuItem_Default.Checked = true; }
					// 取消选中的上一个Item
					SelectItem.Checked = false;
					// 储存当前选中的Item
					SelectItem = toolStripMenuItem_Default;
					// 设置皮肤
					this.BackPalace = global::CashBook.Properties.Resources.DefaultSkin;
					break;
				case "PurpleSkin": // 炫彩紫色
					if (!toolStripMenuItem_Purple.Checked)
					{ 
						toolStripMenuItem_Purple.Checked = true; 
					}
					SelectItem.Checked = false;
					SelectItem = toolStripMenuItem_Purple;
					this.BackPalace = global::CashBook.Properties.Resources.PurpleSkin;
					break;
				case "LilySkin": // 悠然百合
					if (!toolStripMenuItem_Lily.Checked)
					{ 
						toolStripMenuItem_Lily.Checked = true; 
					}
					SelectItem.Checked = false;
					SelectItem = toolStripMenuItem_Lily;
					this.BackPalace = global::CashBook.Properties.Resources.LilySkin;
					break;
				case "GreenSkin": // 绿化环保
					if (!toolStripMenuItem_Green.Checked)
					{ 
						toolStripMenuItem_Green.Checked = true; 
					}
					SelectItem.Checked = false;
					SelectItem = toolStripMenuItem_Green;
					this.BackPalace = global::CashBook.Properties.Resources.GreenSkin;
					break;
				case "LogCharm": // 原木韵味
					if (!toolStripMenuItem_LogCharm.Checked){ toolStripMenuItem_LogCharm.Checked = true; }
					SelectItem.Checked = false;
					SelectItem = toolStripMenuItem_LogCharm;
					this.BackPalace = global::CashBook.Properties.Resources.LogCharm;
					break;
				case "SpringFestival": // 恭贺新春
					if (!toolStripMenuItem_SpringFestival.Checked){ toolStripMenuItem_SpringFestival.Checked = true; }
					SelectItem.Checked = false;
					SelectItem = toolStripMenuItem_SpringFestival;
					this.BackPalace = global::CashBook.Properties.Resources.SpringFestival;
					break;
			}

		}

		private void FormCashBookMenu_FormClosing(object sender, FormClosingEventArgs e)
		{
			objConn.CloseConnectionSqlite();
			DialogResult result = MessageBox.Show("亲，您确定退出吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				this.Dispose();
				Application.Exit();
			}
			else
			{
				e.Cancel = true;
			}
		}

		private void toolStripMenuItem_Calc_Click(object sender, EventArgs e)
		{
			System.Diagnostics.ProcessStartInfo calcInfo = new System.Diagnostics.ProcessStartInfo();
			calcInfo.FileName = "calc.exe";
			System.Diagnostics.Process proc = System.Diagnostics.Process.Start(calcInfo);
		}

		private void toolStripMenuItem_NotePad_Click(object sender, EventArgs e)
		{
			System.Diagnostics.ProcessStartInfo NotePadInfo = new System.Diagnostics.ProcessStartInfo();
			NotePadInfo.FileName = "notepad.exe";
			System.Diagnostics.Process proc = System.Diagnostics.Process.Start(NotePadInfo);
		}

		private void toolStripMenuItem_LogOut_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("亲，您确定注销登录吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Dispose();			// 退出时释放所有资源
				Application.Exit(); 	// 通知所有窗口退出
				System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
			}
			else
			{
				this.DialogResult = DialogResult.No;
			}
		}

		private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("亲，您确定退出吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				this.Dispose();
				Application.Exit();
			}
			else
			{
				this.DialogResult = DialogResult.No;
			}
		}

	
		private void toolStripMenuItem_CheckUpdate_Click(object sender, EventArgs e)
		{
			FormUpdate frmUpdate = new FormUpdate();
			frmUpdate.ShowDialog();
		}

		private void toolStripMenuItem_Feedback_Click(object sender, EventArgs e)
		{
			FormFeedBack frm = new FormFeedBack();
			frm.ShowDialog();
		}

		private void toolStripMenuItem_About_Click(object sender, EventArgs e)
		{
			FormAbount frmAbount = new FormAbount();
			frmAbount.ShowDialog();
		}

		// 资料修改
		private void ToolStripMenuItem_DataModify_Click(object sender, EventArgs e)
		{

		}

		#region ListView显示数据
		// ListView显示数据
		public void listShowData()
		{
			listView_ShowData.Items.Clear();
			const string TableUsers = "t_users";
			string sql_qry_t_cashbook_info = string.Format("SELECT * FROM {0} WHERE UID IN(SELECT UID FROM {1} WHERE ACC='{2}')", TableCashBookInfo, TableUsers, frm.GetAccount());
			using (SQLiteDataReader dr = objConn.SelectDataFromSqlite(sql_qry_t_cashbook_info))
			{
				while (dr.Read())
				{
					listView_ShowData.BeginUpdate();
					ListViewItem lt = new ListViewItem();
					lt.Text = dr["ID"].ToString();
					lt.SubItems.Add(dr["DateTime"].ToString());
					lt.SubItems.Add(dr["TallyType"].ToString());
					lt.SubItems.Add(dr["BudgetType"].ToString());
					lt.SubItems.Add(dr["Amount"].ToString());
					lt.SubItems.Add(dr["InOutProject"].ToString());
					lt.SubItems.Add(Convert.ToDouble(dr["Income"]).ToString("C"));
					lt.SubItems.Add(Convert.ToDouble(dr["PayOut"]).ToString("C"));
					lt.SubItems.Add(Convert.ToDouble(dr["Total"]).ToString("C"));
					lt.SubItems.Add(dr["PayMode"].ToString());
					lt.SubItems.Add(dr["RecordUser"].ToString());
					lt.SubItems.Add(dr["Remark"].ToString());
					listView_ShowData.Items.Add(lt);
					listView_ShowData.EndUpdate();
				}
			}
			// 隔行变色
			for (int index = 0; index < this.listView_ShowData.Items.Count; index++)
			{
				if ((index % 2) != 0)
				{
					this.listView_ShowData.Items[index].BackColor = Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
				}
			}
			// ListView宽自适应界面
			listView_ShowData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}
		#endregion

		#region 查询
		// 查询
		private void Btn_Query_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox_Query.Text))
			{
				this.textBox_Query.SkinTxt.WaterText = "请输入查询关键字";
				return;
			}
			else
			{
				toolStripMenuItem_Refresh_Click(sender, e);	// 查询之前先刷新数据
				QueryKeyWord(comboBox_Type.Text, textBox_Query.Text);
			}
		}
		
		private void QueryKeyWord(string columnName, string rowName)
		{
			for (int i = 0; i < listView_ShowData.Columns.Count; i++)
			{
				// 找列名，列保持不变
				if (columnName.Equals(listView_ShowData.Columns[i].Text))
				{
					// 找到列名，列号不变，行号增加纵向遍历
					for (int j = 0; j < listView_ShowData.Items.Count; )
					{
						if (radioButton_Accurate.Checked)	// 精确查询
						{
							if (!rowName.Equals(listView_ShowData.Items[j].SubItems[i].Text))
							{
								// 与查找的关键词不等则移除
								listView_ShowData.Items.Remove(listView_ShowData.Items[j]);
							}
							else
							{
								// 与查找的关键词相等则保留
								j++;
							}
						}
						else if (radioButton_Vague.Checked)	// 模糊查询
						{
							string str = listView_ShowData.Items[j].SubItems[i].Text;
							if (!str.Contains(rowName))
							{
								// 查找的关键词不被包含则移除
								listView_ShowData.Items.Remove(listView_ShowData.Items[j]);
							}
							else
							{
								// 查找的关键词被包含则保留
								j++;
							}
						}
					}
					break;	// 找到对应列类型后就不在遍历
				}
			}
		}
		#endregion

		#region 换肤按钮
		// 换肤按钮
		private void SysBtn_ChangeSkin(object sender, CCWin.SkinControl.SysButtonEventArgs e)
		{
			Point pos = PointToScreen(e.SysButton.Location);
			pos.Y += e.SysButton.Size.Height + 1;
			if (e.SysButton.Name == "SysBtn_ChangeSkin")
			{
				contextMenuStrip_ToolSkin.Show(pos);
			}
		}
		#endregion

		#region 换肤菜单
		/// <summary>
		/// 换肤菜单 - 选中的MenuItem
		/// </summary>
		ToolStripMenuItem SelectItem = new ToolStripMenuItem();
		private void toolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem item = (ToolStripMenuItem)sender;
			// 选中当前Item，如果已经选中则返回
			if (item.Checked)
			{
				return;
			}
			else
			{
				item.Checked = true;
			}

			// 取消选中的上一个Item并储存当前选中的Item
			SelectItem.Checked = false;
			
			// 储存当前选中的Item
			SelectItem = item;

			// 将用户设置的皮肤保存至配置文件中
			CashBookConfig.UpdateAppConfig("Skin", item.Tag.ToString());
			
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCashBookMenu));
			switch (item.Tag.ToString())
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
		#endregion

		public void ThreadStartFunc(Action Func)
		{
			ThreadStart threadStart = new ThreadStart(Func);
			Thread thread = new Thread(threadStart);
			thread.IsBackground = false;
			thread.Start();
		}
		
		private static string frmModifyTitle = "";
		private void Btn_Add_Click(object sender, EventArgs e)
		{
			frmModifyTitle = "新增账单";
			FormAdd frmAdd = new FormAdd();
			frmAdd.ShowDialog();
			if (Clipboard.GetText().ToString().Equals("确定"))
			{
				listView_ShowData.Items.Clear();
				listShowData();	// 显示数据
			}
		}

		private void Btn_Modify_Click(object sender, EventArgs e)
		{
			GetDataFromListView();
			if (listView_ShowData.SelectedItems.Count == 0)
			{
				MessageBox.Show("请选择一条记录进行修改", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			frmModifyTitle = "修改账单";
			FormAdd frmModify = new FormAdd();
			frmModify.ShowDialog();
			if (Clipboard.GetText().ToString().Equals("确定"))
			{
				listView_ShowData.Items.Clear();
				listShowData();	// 显示数据
			}
		}

		private void Btn_Delete_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < listView_ShowData.Items.Count; i++)
			{
				if (listView_ShowData.SelectedItems.Count == 0 && !listView_ShowData.Items[i].Checked)
				{
					MessageBox.Show("请至少选择一条记录进行删除", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
			}

			if (MessageBox.Show("亲，您确定删除吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				for (int i = 0; i < listView_ShowData.Items.Count; i++)
				{
					for (int j = listView_ShowData.SelectedItems.Count - 1; j >= 0; j--)
					{
						string sql_delete_seleted = string.Format("delete from {0} where ID={1}", TableCashBookInfo, listView_ShowData.SelectedItems[i].Text);
						objConn.ExecuteSql(sql_delete_seleted);
						listView_ShowData.Items.Remove(listView_ShowData.SelectedItems[j]);
					}
					if (listView_ShowData.Items.Count > 0 && listView_ShowData.Items[i].Checked)
					{
						string sql_delete_checked = string.Format("delete from {0} where ID={1}", TableCashBookInfo, listView_ShowData.Items[i].Text);
						objConn.ExecuteSql(sql_delete_checked);
						listView_ShowData.Items.Remove(listView_ShowData.Items[i]);
					}
				}
			}
		}

		#region 数据导出TXT
		// 数据导出TXT
		CountdownEvent latch = new CountdownEvent(1);
		private void Btn_Export_Click(object sender, EventArgs e)
		{
			ExportToExcel();
		}

		/// <summary>
		/// 导出TXT函数
		/// </summary>
		
		private void ExportToExcel()
		{
			System.Windows.Forms.SaveFileDialog saveDlg = new SaveFileDialog();
			saveDlg.DefaultExt = "txt";
			saveDlg.FileName = string.Format("账户【{0}】账单记录{1}.txt", frm.GetUserName(), DateTime.Now.ToString("yyyy-MM-dd"));
			saveDlg.Filter = "文本文档(*.txt)|*.txt";
			if (saveDlg.ShowDialog() == DialogResult.OK)
			{
				this.toolStripStatusLabel_StateMsg.Text = "状态: 请稍等，记账数据导出中...";
				DoExport(this.listView_ShowData, saveDlg.FileName);
				this.toolStripStatusLabel_StateMsg.Text = "状态: ";
			}
		}

		/// <summary>
		/// 具体导出函数
		/// </summary>
		/// <param name="list">list</param>
		/// <param name="strFileName">导出的Excel文件名</param>
		private void DoExport(ListView listView, string strFileName)
		{
			// 获取ListView的总行数
			int rowNum = listView.Items.Count;
			if (0 == rowNum || string.IsNullOrEmpty(strFileName))
			{
				return;
			}
			// 有数据即开始导出到TXT中
			if (rowNum > 0)
			{
				//System.Data.SQLite.SQLiteConnection.CreateFile(strFileName);
				System.IO.StreamWriter sw = new System.IO.StreamWriter(strFileName, false, System.Text.Encoding.GetEncoding("GB2312"));
				try
				{
					int len = 0;
					const int step = 21;
					string line = string.Empty;
					string temp = string.Empty;
					// ListView标题
					for (int i = 0; i < listView.Columns.Count; i++)
					{
						temp = listView.Columns[i].Text;
 						len = step - Encoding.Default.GetByteCount(temp) + temp.Length;
 						temp = temp.PadRight(len, ' ');
 						line += temp;
					}
					sw.WriteLine(line);
					line = string.Empty;
					// ListView内容
					for (int i = 0; i < listView.Items.Count; i++)
					{
						for (int j = 0; j < listView.Items[i].SubItems.Count; j++)
						{
							temp = listView.Items[i].SubItems[j].Text;
 							len = step - Encoding.Default.GetByteCount(temp) + temp.Length;
 							temp = temp.PadRight(len, ' ');
							line += temp;
						}
						sw.WriteLine(line);
						line = string.Empty;
					}
					sw.Flush();
				}
				finally
				{
					if (sw != null)
					{
						sw.Close();
					}
				}
			}
			this.toolStripStatusLabel_StateMsg.Text = "状态: 恭喜！记账数据导出成功";
			MessageBox.Show("恭喜！记账数据导出成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		#endregion

		private void toolStripMenuItem_PasswordModify_Click(object sender, EventArgs e)
		{
			FormModifyPassword frm = new FormModifyPassword();
			frm.ShowDialog();
		}

		private void toolStripMenuItem_Add_Click(object sender, EventArgs e)
		{
			this.Btn_Add_Click(sender, e);
		}

		private void toolStripMenuItem_Modify_Click(object sender, EventArgs e)
		{
			this.Btn_Modify_Click(sender, e);
		}

		private void toolStripMenuItem_Delete_Click(object sender, EventArgs e)
		{
			this.Btn_Delete_Click(sender, e);
		}

		private void toolStripMenuItem_Export_Click(object sender, EventArgs e)
		{
			this.Btn_Export_Click(sender, e);
		}

		private void toolStripMenuItem_CheckBox_Click(object sender, EventArgs e)
		{
			if (this.toolStripMenuItem_CheckBox.Text == "多选")
			{
				this.listView_ShowData.CheckBoxes = true;
				this.toolStripMenuItem_CheckBox.Text = "取消多选";
			}
			else
			{
				this.listView_ShowData.CheckBoxes = false;
				this.toolStripMenuItem_CheckBox.Text = "多选";
			}
			
		}

		private void FormCashBookMenu_Resize(object sender, EventArgs e)
		{
			listView_ShowData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		private void toolStripMenuItem_Refresh_Click(object sender, EventArgs e)
		{
			listView_ShowData.Items.Clear();
			listShowData();	// 显示数据
		}

		private void listView_ShowData_SelectedIndexChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < listView_ShowData.SelectedItems.Count; i++)
			{
				string strLineNo = string.Format("行: {0}", listView_ShowData.SelectedItems[i].Text);
				toolStripStatusLabel_LineNo.Text = strLineNo;
			}
		}

		private void listView_ShowData_DoubleClick(object sender, EventArgs e)
		{
			Btn_Modify_Click(sender, e);
		}


	}
}
