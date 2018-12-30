using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using CCWin;

namespace CashBook
{
	class SendFeedBack
	{
		public Boolean SendMsg(string mailSubject, string mailContent)
		{
			// SMTP服务器设置项
			SmtpClient smtp = new SmtpClient(); 
			smtp.DeliveryMethod = SmtpDeliveryMethod.Network; 
			smtp.EnableSsl = true; // smtp服务器是否启用SSL加密
			smtp.Host = "smtp.163.com"; // smtp服务器地址
			smtp.Port = 25; //smtp服务器的端口，默认是25，缺省即默认端口
			// SMTP服务器身份认证
			smtp.UseDefaultCredentials = true;
			// 发件人邮箱的用户和密码(授权码，并非邮箱登录密码)
			smtp.Credentials = new NetworkCredential("wl94011@163.com", "As940118354");

			// 邮件消息设置
			MailMessage mailMsg = new MailMessage();
			mailMsg.Priority = MailPriority.High;	// 优先级
			// 收件方看到的邮件来源(邮件地址,发信人显示的名称,第二个参数的编码)
			mailMsg.From = new MailAddress("wl94011@163.com", "小白兔", Encoding.GetEncoding(936));
			// 邮件的接收者，支持群发，多个地址之间用半角逗号分开
			mailMsg.To.Add(new MailAddress("feedbacktoaley@163.com", "小白兔记账本", Encoding.GetEncoding(936)));
			mailMsg.Subject = mailSubject; //邮件主题
			mailMsg.SubjectEncoding = Encoding.GetEncoding(936);
			mailMsg.IsBodyHtml = true;
			mailMsg.BodyEncoding = Encoding.GetEncoding(936);
			mailMsg.Body = mailContent; //邮件正文
			// 异常捕获
			try
			{
				smtp.Send(mailMsg);
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
