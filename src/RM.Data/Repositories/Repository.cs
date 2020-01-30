using MongoDB.Driver;
using RM.Data.Interfaces;
using RM.Domain.Core.Interfaces;
using RM.Domain.Core.Models;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RM.Data.Repositories
{

    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly IMongoContext Context;
        protected IMongoCollection<T> DbSet;

        protected Repository(IMongoContext context)
        {
            Context = context;
        }

        public virtual void Add(T obj)
        {
            ConfigDbSet();
            Context.AddCommand(() => DbSet.InsertOneAsync(obj));
        }

        private void ConfigDbSet()
        {
            DbSet = Context.GetCollection<T>(typeof(T).Name);
        }

        public virtual async Task<T> GetById(Guid id)
        {
            ConfigDbSet();
            var data = await DbSet.FindAsync(Builders<T>.Filter.Eq("_id", id));
            return data.SingleOrDefault();
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            ConfigDbSet();
            var all = await DbSet.FindAsync(Builders<T>.Filter.Empty);
            return all.ToList();
        }

        public virtual void Update(T obj)
        {
            ConfigDbSet();
            Context.AddCommand(() => DbSet.ReplaceOneAsync(Builders<T>.Filter.Eq("_id", obj.GetId()), obj));
        }

        public virtual void Remove(Guid id)
        {
            ConfigDbSet();
            Context.AddCommand(() => DbSet.DeleteOneAsync(Builders<T>.Filter.Eq("_id", id)));
        }

        public void Dispose()
        {
            Context?.Dispose();
        }

        public IEnumerable<T> Search(Expression<Func<T, bool>> Predicate)
        {
            throw new NotImplementedException();
        }
    }
}
