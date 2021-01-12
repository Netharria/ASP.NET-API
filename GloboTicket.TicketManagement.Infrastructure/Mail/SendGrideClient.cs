namespace GloboTicket.TicketManagement.Infrastructure.Mail
{
    internal class SendGrideClient
    {
        private string apiKey;

        public SendGrideClient(string apiKey)
        {
            this.apiKey = apiKey;
        }
    }
}