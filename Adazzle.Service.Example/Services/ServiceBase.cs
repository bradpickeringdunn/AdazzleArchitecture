using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Backbone.Logging;
using Backbone.Repository;
using Backbone.Services.Results;
using Backbone.Utilities;

namespace Adazzle.Service.Example.Services {
   public class ServiceBase : IDisposable {
      public ILogger Logger { get; set; }

      public IRepository Repository;
      private Timer TimeTaken;

      public ServiceBase(ILogger logger, IRepository repository) {
         Guardian.ArgumentNotNull(logger, "logger");
         Guardian.ArgumentNotNull(repository, "repository");

         this.Logger = logger;
         this.Repository = repository;
         TimeTaken = new Timer();
      }

      public T TryExecute<T>(object request, Action<T> action) where T : GenericServiceResult, new() {
         var result = new T();

         Guardian.ArgumentNotNull(request, "request");
         
         try {
            TimeTaken.Start();
            action(result);
         }
         catch (Exception ex) {
            Logger.Exception(ex);
            result.Notifications.Add("A general service error occurred.");
         }
         finally {
            TimeTaken.Stop();
            Logger.Info(TimeTaken.ToString());
         }

         return result;
      }

      public void Dispose() {
         TimeTaken.Dispose();
      }
   }
}
