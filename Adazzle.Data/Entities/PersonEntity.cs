using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adazzle.Data.Entities {
   public class PersonEntity : BaseEntity {
      public string Name { get; set; }

      public int Age { get; set; }
   }
}
