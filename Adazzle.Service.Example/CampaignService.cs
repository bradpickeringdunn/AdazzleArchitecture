using System;
using OutTheBox.Logging;
using OutTheBox.Repository;
using OutTheBox.Utilities;
using OutTheBox.Services;
using Adazzle.Services.Campaign.Api.Contracts;
using Adazzle.Services.Campaign.Api.Models;

namespace Adazzle.Services.Campaign
{
    public class CampaignService : ServiceBase, ICampaignService
    {
        public CampaignService(ILogger logger, IRepository repo) :
           base(logger, repo)
        {

            //Fail fast if logger is null then any call to it will fail.
            //Rather fail at this point as this is where the source of tie error begins
            Guardian.ArgumentNotNull(logger, "logger");
            Guardian.ArgumentNotNull(repo, "repo");
        }

        public ExampleResult LoadCampaign(ExampleRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
