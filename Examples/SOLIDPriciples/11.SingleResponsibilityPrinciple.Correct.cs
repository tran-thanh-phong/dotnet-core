using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SOLIDPriciples.SingleResponsibilityPrinciple.Correct
{
    public class UserService
    {
        EmailService _emailService;
        DbContext _dbContext;

        public UserService(EmailService aEmailService, DbContext aDbContext)
        {
            _emailService = aEmailService;
            _dbContext = aDbContext;
        }

        public void Register(string email, string password)
        {
            if (!_emailService.ValidateEmail(email))
                throw new ValidationException("Email is not an email");

            var user = new User(email, password);
            _dbContext.Save(user);

            _emailService.SendEmail(new MailMessage("myname@mydomain.com", email) { Subject = "Hi. How are you!" });

        }
    }

    public class EmailService
    {
        SmtpClient _smtpClient;

        public EmailService(SmtpClient aSmtpClient)
        {
            _smtpClient = aSmtpClient;
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

    public class DbContext
    {
        public void Save(User user)
        {

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
