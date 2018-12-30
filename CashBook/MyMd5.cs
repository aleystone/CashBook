using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CashBook
{
	class MyMd5
	{
		public string Md5Encrypt(string encrypt)
		{
			string md5_encrypt = string.Empty;
			string md5_value = string.Empty;
			try
			{
				if (!string.IsNullOrEmpty(encrypt))
				{
					MD5 md5 = MD5.Create();
					byte[] hashBytes1 = md5.ComputeHash(Encoding.UTF8.GetBytes(encrypt));
					for (int i = 0; i < hashBytes1.Length; i++)
					{
						hashBytes1[i] &= 0xFF;
						md5_encrypt += hashBytes1[i].ToString("X").PadLeft(2, '0');
					}

					byte[] hashBytes2 = md5.ComputeHash(Encoding.UTF8.GetBytes(md5_encrypt));
					for (int i = 0; i < hashBytes2.Length; i++)
					{
						hashBytes2[i] &= 0xEF;
						md5_value += hashBytes2[i].ToString("X").PadLeft(2, '1');
					}
				}
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message, "警示",MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			return md5_value;
		}
	}
}
