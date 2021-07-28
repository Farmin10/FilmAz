using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess.RepositoryPattern
{
    public interface IEntityRepository<T> where T:class,new()
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate,params Expression<Func<T,object>>[] includeProperties);
        T Get(Expression<Func<T, bool>> predicate,params Expression<Func<T,object>>[] includeProperties);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate=null, params Expression<Func<T, object>>[] includeProperties);
        List<T> GetAll(Expression<Func<T, bool>> predicate=null, params Expression<Func<T, object>>[] includeProperties);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);
    }
}
