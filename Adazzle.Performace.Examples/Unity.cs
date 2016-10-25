using Adazzle.Data;
using Microsoft.Practices.Unity;
using OutTheBox.Logging;
using OutTheBox.Repository;

namespace Adazzle.Performace.Examples
{
    internal class Unity
    {
        public UnityContainer Initialize()
        {
            var container = new UnityContainer();

            container.RegisterType<ILogger, DebugLogger>();
            container.RegisterType<IRepository, Repository>();

            return container;
        }
    }
}
