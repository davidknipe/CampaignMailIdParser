using System.Web.Mvc;
using CampaignMailIdParser.Filters;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace CampaignMailIdParser.Init
{
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class MailIdFilterConfigInit : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            // Add a global filter to check for the mailId querystring paramter
            GlobalFilters.Filters.Add(context.Locate.Advanced.GetInstance<MailIdFilter>());
        }

        public void Uninitialize(InitializationEngine context) { }
    }
}
