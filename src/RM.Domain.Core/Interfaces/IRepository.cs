using RM.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RM.Domain.Core.Interfaces
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        void Add(T obj);
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();
        void Update(T obj);
        void Remove(Guid id);

        IEnumerable<T> Search(Expression<Func<T, bool>> Predicate);

    }

  

}
