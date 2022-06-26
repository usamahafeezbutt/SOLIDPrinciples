using System.Net.Mail;

namespace SOLIDPrinciples.SingleResponsibilityPrinciple.OrderWithoutSRP
{
    class OrderWithoutSRP
    {
        public string CreateOrder()
            => StoreToDatabase() ? (SendEmailToUser("email@example.com", new MailMessage()) ? 
            "Order Created and email send" : "Order Created But failed to send email") 
            : "Failed to Store in database";

        public bool StoreToDatabase() 
            //Store Order to database
            => true;

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
