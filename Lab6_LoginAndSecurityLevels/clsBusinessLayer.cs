using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// **** Add the following at the top of the class file,
// used to send electronic mail to SMTP server for delivery
using System.Net.Mail;

namespace Lab1_AnnualSalaryCalculator
{
    public class clsBusinessLayer
    {
        //**** Add the following code inside the body of public class clsBusinessLayer ****
        public static bool SendEmail(string Sender, string Recipient, string bcc, string cc,
        string Subject, string Body)
        {
            try
            {
                // Instantiate a new instance of MailMessage
                MailMessage MyMailMessage = new MailMessage();
                // Set the sender address of the mail message
                MyMailMessage.From = new MailAddress(Sender);
                // Set the recepient address of the mail message
                MyMailMessage.To.Add(new MailAddress(Recipient));
                // Check if the bcc value is null or an empty string
                if (bcc != null && bcc != string.Empty)
                {
                    // Set the Bcc address of the mail message
                    MyMailMessage.Bcc.Add(new MailAddress(bcc));
                }
                // Check if the cc value is null or an empty value
                if (cc != null && cc != string.Empty)
                {
                    // Set the CC address of the mail message
                    MyMailMessage.CC.Add(new MailAddress(cc));
                }
                // Set the subject of the mail message
                MyMailMessage.Subject = Subject;
                // Set the body of the mail message
                MyMailMessage.Body = Body;
                // Set the format of the mail message body as HTML
                MyMailMessage.IsBodyHtml = true;
                // Set the priority of the mail message to normal
                MyMailMessage.Priority = MailPriority.Normal;
                // Instantiate a new instance of SmtpClient
                SmtpClient MySmtpClient = new SmtpClient("localhost");
                //SMTP Port = 25;
                //Generic IP host = "127.0.0.1";
                // Send the mail message
                MySmtpClient.Send(MyMailMessage);
                // Pass the data through
                return true;
            }
            catch (Exception ex)
            {
                // If error occurs, don't pass the data through
                return false;
            }
        }
    }
}