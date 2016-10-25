using System;
using Adazzle.Common.Models;
using OutTheBox.Utilities;
using Adazzle.Services.Campaign.Api.Contracts;
using Adazzle.Services.Campaign.Api.Models;

namespace Adazzle.Performace.Examples
{

    public class ExampleAction<T> where T : class {

        private ICampaignService _serviceExample;

        public Func<Common.Models.ExampleResult, T> OnComplete{ get; set; }
        
        public ExampleAction(ICampaignService serviceExample)
        {
            Guardian.ArgumentNotNull(serviceExample, "serviceExample");
            _serviceExample = serviceExample;
        }

      public T Execute(ExampleModel request) {

            Guardian.ArgumentNotNull(request, "request");
            Guardian.InstanceNotNull(OnComplete, "OnComplete");

            var result = new Common.Models.ExampleResult();

            var serviceResult = _serviceExample.LoadCampaign(new ExampleRequest()
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
