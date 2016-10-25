using Adazzle.Services.Campaign.Api.Contracts;
using Adazzle.Services.Campaign.Api.Models;
using OutTheBox.Services.ClientAdapters;
using OutTheBox.Services.Results;

namespace Adazzle.Services.Campaign.Api.ServicesAdapter
{
    public class CampaignServiceAdaptera : ICampaignService
    {
        public ExampleResult LoadCampaign(ExampleRequest request)
        {
            using (var conn = new ServiceConnection<ICampaignService>())
            {
                var proxy = conn.Connect();

                var result =  Adapter.Execute(() => proxy.LoadCampaign(request), () => ServiceResults.GenericError(), conn.CommunicationObject);

                return new ExampleResult();
            }
        }
    }
}
