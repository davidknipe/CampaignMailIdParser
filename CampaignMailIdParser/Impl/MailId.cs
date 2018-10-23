using CampaignMailIdParser.Interfaces;
using EPiServer.ServiceLocation;

namespace CampaignMailIdParser.Impl
{
    [ServiceConfiguration(typeof(IMailId))]
    public class MailId : IMailId
    {
        private readonly ICampaignToken _campaignToken;

        public MailId(ICampaignToken campaignToken)
        {
            _campaignToken = campaignToken;
        }

        public string GetRecipientId(string mailId)
        {
            var clientFactory = new ServiceClientFactory();
            var mailIdClient = clientFactory.GetMailIdClient();
            return mailIdClient.getRecipientId(_campaignToken.GetToken(), mailId);
        }

        public long GetRecipientListId(string mailId)
        {
            var clientFactory = new ServiceClientFactory();
            var mailIdClient = clientFactory.GetMailIdClient();
            return mailIdClient.getRecipientListId(_campaignToken.GetToken(), mailId);
        }

    }
}
