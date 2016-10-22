using Backbone.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Adazzle.Data.Entities;

namespace Adazzle.Data
{
    public class Repository : IRepository
    {
        public void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> FindAll<TEntity>() where TEntity : class
        {
         var people = new List<PersonEntity>() {
            new PersonEntity {Name = "Brad", Age = 33 },
            new PersonEntity {Name = "Joao", Age = 17 }
         };


         return (IList<TEntity>)people;
      }

        public IEnumerable<TEntity> FindAll<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
         var people = new List<PersonEntity>() {
            new PersonEntity {Name = "Brad", Age = 33 },
            new PersonEntity {Name = "Joao", Age = 17 }
         };


         return (IList<TEntity>)people;
      }

        public TEntity FindById<TEntity>(int id) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void Save<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void Update<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

      //WOULD NEVER DO THIS BUT ITS FOR THE EXAMPLE
      public IEnumerable<PersonEntity> FindAllPeople() {
         var people = new List<PersonEntity>() {
            new PersonEntity {Name = "Brad", Age = 33 },
            new PersonEntity {Name = "Joao", Age = 17 }
         };

         return people;
      }
    }
}
