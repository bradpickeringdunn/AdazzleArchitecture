using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adazzle.Service.Example.Contracts;
using Adazzle.Service.Example.Services;
using Microsoft.Practices.Unity;
using Backbone.Logging;
using Backbone.Repository;
using Adazzle.Data;
using Adazzle.Performace.Examples.Models;
using Backbone.ErrorHandling;

namespace Adazzle.Performace.Examples {
   class Program {
      static void Main(string[] args) {

            var unityContainer = new Unity().Initialize();
            IServiceExample service = unityContainer.Resolve<IServiceExample>();

            var request = new ExampleModel();
            var errors = new NotificationCollection();

            // Explicitly Resolve the "root" component or components
            var result = new ExampleAction<ExampleResult>(service)
            {
                OnComplete = (m) => { return m; }
            }.Execute(request);
      }
   }
}
