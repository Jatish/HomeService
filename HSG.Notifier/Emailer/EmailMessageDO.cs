using System.Text;
using System.Net.Mail;
using System.Collections.Generic;

namespace HSG.Notifier.Emailer
{
    /// <summary>
    /// Class that holds the message information like To address, Cc address, From address, subject mail message etc.,
    /// </summary>
    /// <c>Version 1.0</c>
    public class EmailMessageDO
    {
        private MailAddress objFrom;
        private MailAddressCollection objTo;
        private MailAddress objReplyTo;
        private MailAddressCollection objCcList;
        private MailAddressCollection objBCcList;
        private string strSubject;
        private string strBody;
        private List<Attachment> objAttachmentList;
        private MailPriority objPriority;
        private Encoding objBodyEncoding;
        private bool bIsBodyHtml;
        private bool bEnableSSl;
        private int iSmtpPort;

        public EmailMessageDO()
        {
            this.objTo = new MailAddressCollection();
            this.objCcList = new MailAddressCollection();
            this.objBCcList = new MailAddressCollection();
            this.strSubject = string.Empty;
            this.strBody = string.Empty;
            this.objAttachmentList = new List<Attachment>();
            this.objPriority = MailPriority.Normal;
            this.objBodyEncoding = Encoding.ASCII;
            this.bIsBodyHtml = true;
            this.bEnableSSl = false;
            this.iSmtpPort = 80;
        }

        public MailAddress From
        {
            get { return this.objFrom; }
            set { this.objFrom = value; }
        }

        public void AddFromAddress(string strEmail, string strDisplayName)
        {
            this.objFrom = new MailAddress(strEmail, strDisplayName, Encoding.UTF32);
        }

        public MailAddressCollection To
        {
            get { return this.objTo; }
            set { this.objTo = value; }
        }

        public void AddToAddress(string strEmail, string strDisplayName)
        {
            this.objTo.Add(new MailAddress(strEmail, strDisplayName));
        }

        public MailAddress ReplyTo
        {
            get { return this.objReplyTo; }
            set { this.objReplyTo = value; }
        }

        public void AddReplyToAddress(string strEmail, string strDisplayName)
        {
            this.objReplyTo = new MailAddress(strEmail, strDisplayName);
        }

        public MailAddressCollection Cc
        {
            get { return this.objCcList; }
            set { this.objCcList = value; }
        }

        public void AddToCcList(string strEmail, string strDisplayName)
        {
            this.objCcList.Add(new MailAddress(strEmail, strDisplayName));
        }

        public MailAddressCollection BCc
        {
            get { return this.objBCcList; }
            set { this.objBCcList = value; }
        }

        public void AddToBCcList(string strEmail, string strDisplayName)
        {
            this.objBCcList.Add(new MailAddress(strEmail, strDisplayName));
        }

        public string Subject
        {
            get { return this.strSubject; }
            set { this.strSubject = value; }
        }

        public string Body
        {
            get { return this.strBody; }
            set { this.strBody = value; }
        }

        public List<Attachment> AttachmentList
        {
            get { return this.objAttachmentList; }
            set { this.objAttachmentList = value; }
        }

        public void AddToAttachmentList(string strFileName)
        {
            this.objAttachmentList.Add(new Attachment(strFileName));
        }

        public void AddToAttachmentList(string strFileName, string strMediaType)
        {
            string strMimeType = string.Empty;
            if (strMediaType.Equals("pdf"))
                strMimeType = System.Net.Mime.MediaTypeNames.Application.Pdf;
            else if (strMediaType.Equals("txt"))
                strMimeType = System.Net.Mime.MediaTypeNames.Text.RichText;
            else if (strMediaType.Equals("gif"))
                strMimeType = System.Net.Mime.MediaTypeNames.Image.Gif;
            else
                strMimeType = System.Net.Mime.MediaTypeNames.Application.Octet;

            this.objAttachmentList.Add(new Attachment(strFileName, strMimeType));
        }

        public MailPriority Priority
        {
            get { return this.objPriority; }
            set { this.objPriority = value; }
        }

        public Encoding BodyEncoding
        {
            get { return this.objBodyEncoding; }
            set { this.objBodyEncoding = value; }
        }

        public bool IsBodyHtml
        {
            get { return this.bIsBodyHtml; }
            set { this.bIsBodyHtml = value; }
        }

        public bool EnableSSL
        {
            get { return this.bEnableSSl; }
            set { this.bEnableSSl = value; }
        }

        public int SmtpPort
        {
            get { return this.iSmtpPort; }
            set { this.iSmtpPort = value; }
        }
    }
}
