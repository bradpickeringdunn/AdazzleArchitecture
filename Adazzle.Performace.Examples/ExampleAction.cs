using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backbone.Logging;
using Backbone.Repository;
using Backbone.Utilities;
using Adazzle.Service.Example.Contracts;
using Backbone.ErrorHandling;
using Adazzle.Performace.Examples.Models;
using Adazzle.Performace.Examples.Mappings;

namespace Adazzle.Performace.Examples {

   public class ExampleAction<T> where T : class {

        private IServiceExample _serviceExample;

        public Func<ExampleResult, T> OnComplete{ get; set; }
        
        public ExampleAction(IServiceExample serviceExample)
        {
            Guardian.ArgumentNotNull(serviceExample, "serviceExample");
            _serviceExample = serviceExample;
        }

      public T Execute(ExampleModel request) {

            Guardian.ArgumentNotNull(request, "request");
            Guardian.InstanceNotNull(OnComplete, "OnComplete");

            var result = new ExampleResult();

            var serviceResult = _serviceExample.EndpointExample(request.AsServiceRequest());
            
            if(serviceResult.IsNull() || serviceResult.Notifications.HasErrors)
            {
                result.Notifications.Add("There was an unexpected error.");
            }

            if(serviceResult.IsNotNull() && !serviceResult.Notifications.HasErrors)
            {
                result = serviceResult.ToExampleResult();
            }

            return OnComplete(result);
      }

   }
}
