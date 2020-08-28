using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BooksWeagon.Email
{
   public class SendEmail
    {
        public static void Send_Report_In_Mail()//for mail
        {// details of mail credentials
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");//arugment server gmail
            mail.From = new MailAddress("pallavidubey6232@gmail.com");//sender
            mail.To.Add("rebelpallavi786@gmail.com");//reciver

            StringBuilder TimeAndDate = new StringBuilder(DateTime.Now.ToString());//getting date
            TimeAndDate.Replace("/", "_");
            TimeAndDate.Replace(":", "_");

            mail.Subject = "Automation Test Report_"+TimeAndDate;//adding date to mail

            mail.Body = "Please find the attached report to get details.”";//data passing to body

            var mostRecentlyModified = Directory.GetFiles(@"C:\Users\rebel\source\repos\BooksWeagon\BooksWeagon\Extentreport\", "*.html")
            .Select(f => new FileInfo(f))
            .OrderByDescending(fi => fi.LastWriteTime)
            .First()
            .FullName;

            Attachment attachment;
            attachment = new Attachment(mostRecentlyModified);
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;//cretenial detail
            SmtpServer.Credentials = new System.Net.NetworkCredential("pallavidubey6232@gmail.com", "12respect34");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);

        }
    }
}
