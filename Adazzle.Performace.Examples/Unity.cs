using Adazzle.Data;
using Adazzle.Service.Example.Contracts;
using Adazzle.Service.Example.Services;
using Backbone.Logging;
using Backbone.Repository;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adazzle.Performace.Examples
{
    internal class Unity
    {
        public UnityContainer Initialize()
        {
            var container = new UnityContainer();

            container.RegisterType<ILogger, DebugLogger>();
            container.RegisterType<IRepository, Repository>();
            container.RegisterType<IServiceExample, ServiceExample>();

            return container;
        }
    }
}
