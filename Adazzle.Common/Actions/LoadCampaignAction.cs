using System;
using Adazzle.Common.Models;
using OutTheBox.Utilities;
using Adazzle.Services.Campaign.Api.Contracts;
using System.Web.Services.Description;

namespace Adazzle.Common.Actions
{

    public class LoadCampaignAction<T> where T : class {

        private ICampaignService _serviceExample;

        public Func<ExampleResult, T> OnComplete{ get; set; }
        
        public LoadCampaignAction(ICampaignService serviceExample)
        {
            Guardian.ArgumentNotNull(serviceExample, "serviceExample");
            _serviceExample = serviceExample;
        }

      public T Execute(ExampleModel request) {

            Guardian.ArgumentNotNull(request, "request");
            Guardian.InstanceNotNull(OnComplete, "OnComplete");

            var result = new ExampleResult();

            var serviceResult = _serviceExample.LoadCampaign(new Services.Campaign.Api.Models.ExampleRequest()
            {
                Age = request.Age,
                Name = request.Name
            });
            
            if(serviceResult.IsNull() || serviceResult.Notifications.HasErrors)
            {
                result.Notifications.AddError("There was an unexpected error.");
            }

            if(serviceResult.IsNotNull() && !serviceResult.Notifications.HasErrors)
            {
                // result = serviceResult.ToExampleResult();
            }

            return OnComplete(result);
      }

   }
}
