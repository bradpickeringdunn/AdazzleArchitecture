using Adazzle.Performace.Examples.Models;
using Adazzle.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adazzle.Performace.Examples.Mappings
{
    public static class ExampleModelMapping
    {
        public static ExampleRequest AsServiceRequest(this Models.ExampleModel model)
        {
            return new ExampleRequest()
            {
                Name = model.Name,

                Age = model.Age
            };
        }
    }
}
