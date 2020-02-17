using Contracts;
using Entities;
using Entities.DbModels;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected FactoryManagementContext RepositoryContext { get; set; }

        public RepositoryBase(FactoryManagementContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.RepositoryContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {

            Type type = entity.GetType();
            type.GetProperty("CreatedDateTime").SetValue(typeof(DateTime), DateTime.Now);
            type.GetProperty("UpdatedDateTime").SetValue(typeof(DateTime), DateTime.Now);
            type.GetProperty("Id").SetValue(typeof(string), Guid.NewGuid().ToString());
            type.GetProperty("FactoryId").SetValue(typeof(string), type.GetProperty("Id").GetValue(typeof(string)));
            type.GetProperty("RowStatus").SetValue(typeof(string), DB_ROW_STATUS.ADDED.ToString());
            type.GetProperty("UniqueId").SetValue(typeof(string), Guid.NewGuid().ToString());
            this.RepositoryContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
        }
    }
}
