using System.Net;
using System.Net.Mail;
using log4net;
using System;

namespace HSG.Notifier.Emailer
{
    public class Mail
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Mail));

        public string _strSmtpServer;

        public string _strAuthEmail;

        public string _strAuthPassword;

        /// <summary>
        /// Parameterized constructor to intialize Smtp server, from email details
        /// </summary>
        /// <param name="strSmtpServer"></param>
        /// <param name="strAuthEmail"></param>
        /// <param name="strAuthPassword"></param>
        public Mail(string strSmtpServer, string strAuthEmail, string strAuthPassword)
        {
            this._strSmtpServer = strSmtpServer;
            this._strAuthEmail = strAuthEmail;
            this._strAuthPassword = strAuthPassword;
        }

        /// <summary>
        /// Public method to send a mail to one or more number of users specifying the body, subject, 
        /// format of the mail, encoding type, priority etc.,
        /// </summary>
        /// <param name="objMessage"><c><see cref="EmailMessageDO"/></c> containing the complete details like 
        /// from address, to address, cc list, attachments list etc.,</param>
        /// <returns><c>bool</c> true if the mail is sent successfully otherwise false.</returns>
        /// <c>Version 1.0</c>
        public bool SendMail(EmailMessageDO objMessage)
        {
            bool bIsSent = false;
            try
            {
                logger.Debug("Method SendMail - send the password for the User");
                MailMessage objMailMessage = new MailMessage();

                objMailMessage.From = new MailAddress(objMessage.From.Address, objMessage.From.DisplayName);

                foreach (MailAddress objMailAddress in objMessage.To)
                    objMailMessage.To.Add(objMailAddress);

                foreach (MailAddress objMailAddress in objMessage.Cc)
                    objMailMessage.CC.Add(objMailAddress);

                foreach (MailAddress objMailAddress in objMessage.BCc)
                    objMailMessage.Bcc.Add(objMailAddress);

                if (objMessage.ReplyTo != null)
                    objMailMessage.ReplyToList.Add(objMessage.ReplyTo);

                objMailMessage.Sender = objMessage.From;
                objMailMessage.Subject = objMessage.Subject;

                if (objMessage.AttachmentList != null)
                {
                    foreach (Attachment objAttachment in objMessage.AttachmentList)
                    {
                        objAttachment.ContentDisposition.FileName = objAttachment.Name.Substring(objAttachment.Name.LastIndexOf("/") + 1);
                        objMailMessage.Attachments.Add(objAttachment);
                    }
                }
                objMailMessage.Body = objMessage.Body;
                objMailMessage.Priority = MailPriority.High;
                objMailMessage.BodyEncoding = objMessage.BodyEncoding;
                objMailMessage.IsBodyHtml = objMessage.IsBodyHtml;

                SmtpClient objSmtpClient = new SmtpClient(_strSmtpServer);
                objSmtpClient.UseDefaultCredentials = false;
                objSmtpClient.EnableSsl = objMessage.EnableSSL;
                objSmtpClient.Port = objMessage.SmtpPort;
                objSmtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                objSmtpClient.Credentials = new NetworkCredential(_strAuthEmail, _strAuthPassword);                
                objSmtpClient.Send(objMailMessage);
                objMailMessage.Dispose();
                bIsSent = true;
                logger.Debug("Method SendMail - send the password for the User: " + bIsSent);
            }
            catch (Exception objException)
            {
                logger.Error("Method SendMail - Error: " + objException.ToString());
            }

            return bIsSent;
        }
    }
}
