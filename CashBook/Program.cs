using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CashBook
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new FormLogin());

			FormLogin frmCashBook_Login = new FormLogin();	
			frmCashBook_Login.ShowDialog();	// 显示主菜单界面

			if (frmCashBook_Login.DialogResult == DialogResult.OK)
			{
				Application.Run(new FormCashBookMenu());	// 登录验证合法则显示记账主界面
			}
			else
			{
				return;
			}
		}
	}
}
