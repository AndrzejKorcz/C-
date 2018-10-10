using System;

namespace ConsoleApp2
{
    public class EmailService
    {
        public EmailService()
        {
        }

        public string SendMessage(string subject, string message, string recipient)
        {
            var confirmation = "Message sent: " + subject;
            var loggingService = new LoggingService();
            loggingService.LogAction(confirmation);
            return confirmation;
        }
    }
}