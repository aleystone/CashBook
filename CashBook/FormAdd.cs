using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
using CCWin;

namespace CashBook
{
	public partial class FormAdd : Skin_Mac
	{
		FormCashBookMenu frmMenu = new FormCashBookMenu();
		private SQLiteOperate conn = new SQLiteOperate();
		private FormLogin frmLogin = new FormLogin();
	//	private static Boolean IsOKAdd = false;
		public FormAdd()
		{
			InitializeComponent();
			this.Text = frmMenu.GetFrmTitle();	// 新增和修改共用同一个界面，设置不同的标题
			conn.ConnectionToSqliteDB();	// 连接数据库
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

		private void Btn_AddClear_Click(object sender, EventArgs e)
		{
			skinTextBox_Type.Text = string.Empty;
			skinTextBox_Income.Text = string.Empty;
			skinTextBox_PayOut.Text = string.Empty;
			skinTextBox_Amount.Text = string.Empty;
			skinTextBox_Remark.Text = string.Empty;
			skinComboBox_InOutProject.Text = string.Empty;
			skinTextBox_Total.Text = string.Empty;
			comboBox_PayMode.Text = string.Empty;

		}

		private void Btn_AddSave_Click(object sender, EventArgs e)
		{
			if (this.Text.Equals("新增账单"))
			{
				AddNewBillRecord();
			}
			else  
			{
				
				this.skinTextBox_Total.Text = (Convert.ToDouble(this.skinTextBox_Income.Text) - Convert.ToDouble(this.skinTextBox_PayOut.Text)).ToString();
				ModifyBillRecord();	// 修改账单
			}
			Clipboard.SetText(Btn_AddSave.Text);
		}

		private void AddNewBillRecord()
		{
			string strDateTime = dateTimePicker_AddDate.Text;	// 入账时间
			string strTallyType = skinTextBox_Type.Text;	// 账单类型
			string strBudgetType = skinComboBox_BudgetType.Text; // 收支类型
			string strInOutProject = skinComboBox_InOutProject.Text; // 收支项目
			string strPayMode = comboBox_PayMode.Text; // 支付方式
			string strIncome = skinTextBox_Income.Text;	// 收入金额
			string strPayOut = skinTextBox_PayOut.Text;	// 支出金额
			string strAmount = skinTextBox_Amount.Text;	// 数量
			string strRecordUser = skinTextBox_RecordUser.Text; // 记账人
			string strRemark = skinTextBox_Remark.Text;	// 备注


			if (string.IsNullOrEmpty(strTallyType))
			{
				MessageBox.Show("亲，账单类型不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strBudgetType))
			{
				MessageBox.Show("亲，收支类型不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strAmount))
			{
				MessageBox.Show("亲，数量不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strInOutProject))
			{
				MessageBox.Show("亲，收支项目不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strIncome))
			{
				MessageBox.Show("亲，收入金额不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strPayOut))
			{
				MessageBox.Show("亲，支出金额不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strPayMode))
			{
				MessageBox.Show("亲，支付方式不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strRecordUser))
			{
				MessageBox.Show("亲，记账人不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strRemark))
			{
				strRemark = "常规记账";
			}

			string TableCashBookInfo = FormCashBookMenu.TableCashBookInfo;
			string TableUsers = "t_users";
			string sql_insert_t_cashbook_info = string.Format("INSERT INTO {0}(UID,DateTime,TallyType,BudgetType,Amount,InOutProject,Income,PayOut,Total,PayMode,RecordUser,Remark) SELECT UID,'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}' FROM {12} WHERE ACC='{13}'", TableCashBookInfo, strDateTime, strTallyType, strBudgetType, strAmount, strInOutProject, strIncome, strPayOut, skinTextBox_Total.Text, strPayMode, strRecordUser, strRemark, TableUsers, frmLogin.GetAccount());
			conn.ExecuteSql(sql_insert_t_cashbook_info);
			MessageBox.Show("添加成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}


		private void ModifyBillRecord()
		{
			string strDateTime = dateTimePicker_AddDate.Text;	// 入账时间
			string strTallyType = skinTextBox_Type.Text;	// 账单类型
			string strBudgetType = skinComboBox_BudgetType.Text; // 收支类型
			string strInOutProject = skinComboBox_InOutProject.Text; // 收支项目
			string strPayMode = comboBox_PayMode.Text; // 支付方式
			string strIncome = skinTextBox_Income.Text;	// 收入金额
			string strPayOut = skinTextBox_PayOut.Text;	// 支出金额
			string strAmount = skinTextBox_Amount.Text;	// 数量
			string strRecordUser = skinTextBox_RecordUser.Text; // 记账人
			string strRemark = skinTextBox_Remark.Text;	// 备注

			if (string.IsNullOrEmpty(strTallyType))
			{
				MessageBox.Show("亲，账单类型不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strBudgetType))
			{
				MessageBox.Show("亲，收支类型不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strAmount))
			{
				MessageBox.Show("亲，数量不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strInOutProject))
			{
				MessageBox.Show("亲，收支项目不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strIncome))
			{
				MessageBox.Show("亲，收入金额不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strPayOut))
			{
				MessageBox.Show("亲，支出金额不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strPayMode))
			{
				MessageBox.Show("亲，支付方式不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strRecordUser))
			{
				MessageBox.Show("亲，记账人不能为空！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (string.IsNullOrEmpty(strRemark))
			{
				strRemark = "常规记账";
			}

			string TableCashBookInfo = FormCashBookMenu.TableCashBookInfo;
			string sql_insert_t_cashbook_info = string.Format("UPDATE {0} SET DateTime='{1}',TallyType='{2}',BudgetType='{3}',Amount='{4}',InOutProject='{5}',Income='{6}',PayOut='{7}',Total='{8}',PayMode='{9}',RecordUser='{10}',Remark='{11}' WHERE ID='{12}'", TableCashBookInfo, strDateTime, strTallyType, strBudgetType, strAmount, strInOutProject, strIncome, strPayOut, skinTextBox_Total.Text, strPayMode, strRecordUser, strRemark, strID);
			conn.ExecuteSql(sql_insert_t_cashbook_info);
			MessageBox.Show("修改成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}

		/// <summary>
		/// 修改账单记录
		/// </summary>
		string strID = string.Empty;
		private void GetBillRecord()
		{
			List<string> DataFromListView =  frmMenu.GetDataFromListView();
			if (DataFromListView.Count != 0)
			{
				strID = DataFromListView[0];
				dateTimePicker_AddDate.Text = DataFromListView[1];
				skinTextBox_Type.Text = DataFromListView[2];
				skinComboBox_BudgetType.Text = DataFromListView[3];
				skinTextBox_Amount.Text = DataFromListView[4];
				skinComboBox_InOutProject.Text = DataFromListView[5];
				skinTextBox_Income.Text = DataFromListView[6].Replace("¥", "").Replace(",", "");
				skinTextBox_PayOut.Text = DataFromListView[7].Replace("¥", "").Replace(",", "");
				skinTextBox_Total.Text = DataFromListView[8].Replace("¥", "").Replace(",", "");
				comboBox_PayMode.Text = DataFromListView[9];
				skinTextBox_RecordUser.Text = DataFromListView[10];
				skinTextBox_Remark.Text = DataFromListView[11];
			}
		}

		private void skinButton_Cancel_Click(object sender, EventArgs e)
		{
			frmMenu.GetDataFromListView().Clear();
			this.Close();
		}

		private void FormAdd_Load(object sender, EventArgs e)
		{
			skinTextBox_RecordUser.Text = frmLogin.GetUserName();	// 记账人
			GetBillRecord();	// 修改账单
		}

		System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"^[0-9.]+$");
		private void skinTextBox_Total_Enter(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(skinTextBox_Income.Text) || string.IsNullOrEmpty(skinTextBox_PayOut.Text))
			{
				return;
			}
			// 合计金额
			if (!reg.IsMatch(skinTextBox_Income.Text) || !reg.IsMatch(skinTextBox_PayOut.Text))
			{
				skinTextBox_Income.Text = skinTextBox_PayOut.Text = string.Empty;
				MessageBox.Show("亲, 收入和支出金额只能为数字！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			this.skinTextBox_Total.Text = (Convert.ToDouble(this.skinTextBox_Income.Text) - Convert.ToDouble(this.skinTextBox_PayOut.Text)).ToString();
		}

		private void skinTextBox_Income_Enter(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(skinTextBox_Amount.Text))
			{
				return;
			}
			if (!reg.IsMatch(skinTextBox_Amount.Text))
			{
				skinTextBox_Amount.Text = string.Empty;
				MessageBox.Show("亲, 数量只能为数字！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
		}

		private void FormAdd_FormClosing(object sender, FormClosingEventArgs e)
		{
			
		}

	}
}
