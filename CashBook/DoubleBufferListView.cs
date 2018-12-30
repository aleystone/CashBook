using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashBook
{
	// 自定义控件DoubleBufferListView
	public partial class DoubleBufferListView : ListView
	{
		public DoubleBufferListView()
		{
			InitializeComponent();
			// 双缓冲处理避免重绘界面出现闪烁现象
			base.SetStyle(ControlStyles.DoubleBuffer |
				ControlStyles.OptimizedDoubleBuffer |
				ControlStyles.AllPaintingInWmPaint |
				ControlStyles.ResizeRedraw, true);
			base.UpdateStyles();
		}
	}
}
