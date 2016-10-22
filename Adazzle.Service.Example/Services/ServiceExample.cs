using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adazzle.Data.Entities;
using Adazzle.Service.Example.Contracts;
using Adazzle.Service.Models;
using Backbone.Logging;
using Backbone.Repository;
using Backbone.Services.Results;
using Backbone.Utilities;

namespace Adazzle.Service.Example.Services
{
    public class ServiceExample : ServiceBase, IServiceExample {
      public ServiceExample(ILogger logger, IRepository repo) :
         base(logger, repo) {

         //Fail fast if logger is null then any call to it will fail.
         //Rather fail at this point as this is where the source of tie error begins
         Guardian.ArgumentNotNull(logger, "logger");
         Guardian.ArgumentNotNull(repo, "repo");
      }

      
      public ExampleResult EndpointExample(ExampleRequest request) {

         return TryExecute< Models.ExampleResult > (request, (result) =>
         {
            var person = Repository.FindAll<PersonEntity>().Where(x => x.Name.Equals(request.Name)).FirstOrDefault();
            Guardian.InstanceNotNull(person, "person");

            result.CanHaveAHUGEGlassOfWine = person.Age > 18 ? true : false;
         });
      }

    }
}
