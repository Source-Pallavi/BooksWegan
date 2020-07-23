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
        public static void Send_Report_In_Mail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("pallavidubey6232@gmail.com");
            mail.To.Add("rebelpallavi786@gmail.com");

            StringBuilder TimeAndDate = new StringBuilder(DateTime.Now.ToString());
            TimeAndDate.Replace("/", "_");
            TimeAndDate.Replace(":", "_");

            mail.Subject = "Automation Test Report_"+TimeAndDate;

            mail.Body = "Please find the attached report to get details.”";

            var mostRecentlyModified = Directory.GetFiles(@"C: \Users\rebel\source\repos\BooksWeagon\BooksWeagon\Extentreport\", "*.html")
            .Select(f => new FileInfo(f))
            .OrderByDescending(fi => fi.LastWriteTime)
            .First()
            .FullName;

            Attachment attachment;
            attachment = new Attachment(mostRecentlyModified);
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("pallavidubey6232@gmail.com", "12respect34");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
    }
}
