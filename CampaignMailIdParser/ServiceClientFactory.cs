using System.ServiceModel;

namespace CampaignMailIdParser
{
    /// <summary>
    /// Use this factory to get the service client and avoid the need for system.serviceModel configuration
    /// </summary>
    internal class ServiceClientFactory
    {
        private readonly string baseApiUrl = "https://api.campaign.episerver.net";

        public MailIdWebserviceClient GetMailIdClient()
        {
            return new MailIdWebserviceClient(
                new BasicHttpBinding(BasicHttpSecurityMode.Transport),
                new EndpointAddress(baseApiUrl + "/soap11/MailId"));
        }
    }
}
