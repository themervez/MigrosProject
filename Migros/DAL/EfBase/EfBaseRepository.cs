using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EfBase
{
    public class EfBaseRepository<T, MContext> : IEfBaseRepository<T>
        where T : class
        where MContext : DbContext
    {
        protected readonly MContext Context;
        public EfBaseRepository(MContext context)
        {
            Context = context;
        }

        public T Add(T entity)
        {
            return Context.Add(entity).Entity;

        }

        public T Update(T entity)
        {
            Context.Update(entity);
            return entity;
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> expression = null)
        {
            if (expression == null)
                return Context.Set<T>().ToList();
            else
            {


                return Context.Set<T>().Where(expression);

            }
        }

        public void Delete(T entity)
        {
            Context.Remove(entity);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            //Context.Set<T>().Where(expression).FirstOrDefault();
            //Context.Set<T>().Where(expression).SingleOrDefault();

            return Context.Set<T>().FirstOrDefault(expression);
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
