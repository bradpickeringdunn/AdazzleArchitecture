using Adazzle.Services.Campaign.Api.Models;
using System.ServiceModel;

namespace Adazzle.Services.Campaign.Api.Contracts
{
    [ServiceContract]
    public interface ICampaignService {

        [OperationContract]
        ExampleResult LoadCampaign(ExampleRequest request);
    }
}
