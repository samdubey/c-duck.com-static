using System;
using System.Collections.Generic;

using System.Web;
using System.Web.Services;
using System.Net.Mail;
using System.Web.Script.Services;

namespace cduckcs.webservice
{
    /// <summary>
    /// Summary description for service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class service : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void SendEmailNewsLetterSignUp(string Email)
        {
            SendEmail(" C-Duck Consultancy Services Sign up from - [" + Email + "]", "[" + Email + "] has signed up to the cduck newsletter.");
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void SendEmailContactUs(string Email, string Name, string Message)
        {
            string Subject = "Contact form C-Duck Consultancy Services [" + Name + "]";
            string Body = "Name : [" + Name + "]";
            Body += "<br />";
            Body += "Email : [" + Email + "]";
            Body += "<br />";
            Body += "Message : [" + Message + "]";
            SendEmail(Subject, Body);
        }

        public void SendEmail(string subject, string body)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add("info@c-duck.com");
            mail.From = new MailAddress("webmaster@c-duck.com");
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("webmaster@c-duck.com", "Wind123456");
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}
