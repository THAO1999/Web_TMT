using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
   public interface IRepository<T> where T :class
    {
        //
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteMulti(Expression<Func<T, bool>> where);
        T GetSingleById(int id);
        IQueryable<T> GetAll(string[] includes = null);
         IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);
        IQueryable<T> GetSingLeByCondition(Expression<Func <T, bool>> filter, string[] includes = null);
        int Count(Expression<Func<T, bool>> where);
        bool checkContains(Expression<Func<T, bool>> predicate);

    }
}
