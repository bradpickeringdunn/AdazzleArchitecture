using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backbone.Services.Results;

namespace azzle.Service.Api.Models {
   public class ExampleResult : GenericServiceResult {

      //Response properties go here E.g. database results.
      public dynamic ListDatabaseResults { get; set; }
   }
}
