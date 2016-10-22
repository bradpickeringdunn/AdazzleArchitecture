using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adazzle.Service.Models;
using Backbone.Services.Results;

namespace Adazzle.Service.Example.Contracts {
   public interface IServiceExample {

        ExampleResult EndpointExample(ExampleRequest request) ;

   }
}
