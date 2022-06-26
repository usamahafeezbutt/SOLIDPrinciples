
using System.Net.Mail;

namespace SOLIDPrinciples.SingleResponsibilityPrinciple.OrderWithSRP
{
    public class EmailService
    {
        public bool SendEmailToUser(string email, MailMessage message)
        {
            if (ValidateEmail(email))
            {
                // Send an email to specified address
                new SmtpClient().Send(message);
                return true;
            }
            return false;
        }


        public bool ValidateEmail(string email)
            // check whether the email is valid email or not
            => true;
    }
}
