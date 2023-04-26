using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SOLIDPriciples.SingleResponsibilityPrinciple
{
    public class UserService
    {
        private SmtpClient _smtpClient = new SmtpClient();

        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new ValidationException("Email is not an email");

            var user = new User(email, password);

            SendEmail(new MailMessage("mysite@nowhere.com", email) { Subject = "HEllo foo" });
        }

        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public bool SendEmail(MailMessage message)
        {
            return _smtpClient.Send(message);
        }
    }

    public class User
    {
        public User(string email, string password)
        { 
            
        }
    }

    public class SmtpClient
    {
        public bool Send(MailMessage message)
        {
            Console.WriteLine($"Sent an email to {message.To}");
            return true;
        }
    }
}
