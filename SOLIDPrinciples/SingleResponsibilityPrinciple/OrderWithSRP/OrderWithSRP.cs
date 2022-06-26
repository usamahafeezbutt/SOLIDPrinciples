using System.Net.Mail;

namespace SOLIDPrinciples.SingleResponsibilityPrinciple.OrderWithSRP
{
    class OrderWithSRP
    {
        public string CreateOrder()
           => new DatabaseService().StoreToDatabase() ? 
            ( new EmailService().SendEmailToUser("email@example.com", new MailMessage()) ?
           "Order Created and email send" : "Order Created But failed to send email")
           : "Failed to Store in database";
    }
}
