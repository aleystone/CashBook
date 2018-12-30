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
using CCWin;

namespace CashBook
{
    public class SQLiteOperate
    {
        private string DataSource; // 数据库文件名
		private string Password;
		System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection();
        System.Data.SQLite.SQLiteConnectionStringBuilder connString = new System.Data.SQLite.SQLiteConnectionStringBuilder();
        System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand();
        System.Data.ConnectionState connState = new System.Data.ConnectionState();
		
        public SQLiteOperate()
        {
			// 初始化
			DataSource = @".\CashBookData.db";	// 数据库文件名
			connString.DataSource = DataSource;
			Password = "@CashBook263691.";	// 数据库密码
			connString.Password = Password;
			conn.ConnectionString = connString.ToString();
        }

		#region 创建SQLiteDB文件
		// 创建SQLiteDB文件
		public void CreateSqliteDBFile()	
        {
            // 若数据库文件不存在则创建数据库文件
            if (!(System.IO.File.Exists(DataSource)))
            {
                try
                {
                    System.Data.SQLite.SQLiteConnection.CreateFile(DataSource);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
                }
			}
			
			if (connState == ConnectionState.Closed)
			{
				conn.Open();						// 打开数据库
				conn.ChangePassword(Password);		// 设置数据库密码
				conn.Close();						// 密码设置后关闭数据库连接
			}
        }
		#endregion

		#region 连接数据库
		// 连接数据库
		public void ConnectionToSqliteDB()	// 连接数据库
		{
			try
			{
				if (connState == ConnectionState.Closed)
				{
					conn.SetPassword(Password);		// 用密码打开数据库
					conn.Open();					// 打开数据库
					cmd.Connection = conn;			// 连接到数据库 
				}
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
		#endregion

		#region 创建表
		// 创建表
		public void CreateTableToSqlite(string tableName, string createTableSql)
        {
            string sql_query_data = string.Format("SELECT count(*) FROM sqlite_master WHERE type='table' AND name='{0}'", tableName);
            cmd.CommandText = sql_query_data;
            cmd.Connection = conn;
			try
			{
				if (0 == Convert.ToInt32(cmd.ExecuteScalar()))  // 如果表不存在则创建表
				{
					cmd.CommandText = createTableSql;	// 创建注册用户表
					cmd.Connection = conn;
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
        }
		#endregion

		public void ExecuteSql(string sql)
        {
			try
			{
				cmd.CommandText = sql;
				cmd.ExecuteNonQuery();
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
        }

        public void CloseConnectionSqlite()
        {
            if (connState == ConnectionState.Open)
            {
                conn.Close();   // 关闭数据库连接
            }
        }

		#region 条件查询数据按字段值返回
		// 条件查询数据按字段值返回
		public string[] SelectDataFromSqlite(string sql, string[] data, int len)
        {
			cmd.CommandText = sql;
			try
			{
				using (SQLiteDataReader readerData = cmd.ExecuteReader())
				{
					while (readerData.Read())
					{
						
						for (int i = 0; i < len; i++)
						{
							data[i] = readerData[i].ToString();
						}
					}
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			return data;
		}
		#endregion
		
		// 读取数据返回SQLiteDataReader对象集合
		public SQLiteDataReader SelectDataFromSqlite(string sql)
		{
			cmd.CommandText = sql;
			SQLiteDataReader dr = cmd.ExecuteReader();
			CloseConnectionSqlite();
			return dr;
		}

    }
}
