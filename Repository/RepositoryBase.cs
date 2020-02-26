using Contracts;
using Entities;
using Entities.DbModels;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected FactoryManagementContext RepositoryContext { get; set; }

        public RepositoryBase(FactoryManagementContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }
        public async Task<long>  NumOfRecord() {
        return await RepositoryContext.Set<T>().AsQueryable().CountAsync(); 
        }
        public IQueryable<T> FindAll()
        {
            return this.RepositoryContext.Set<T>().AsNoTracking();
        }
              
        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await this.FindAll().ToListAsync();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }

        public async Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression)
        {
            return await this.FindByCondition(expression).ToListAsync();
        }

        public T Create(T entity)
        {

            Type type = entity.GetType();

             PropertyInfo?  prop =  type.GetProperty("CreatedDateTime");
            PropertyInfo? prop8 = type.GetProperty("CreatedDateTime");

           //type.GetProperty()
            type.GetProperty("CreatedDateTime").SetValue(entity, DateTime.Now);
            type.GetProperty("UpdatedDateTime").SetValue(entity, DateTime.Now);
            type.GetProperty("Id").SetValue(entity, Guid.NewGuid().ToString());
       //     type.GetProperty("FactoryId").SetValue(entity, type.GetProperty("Id").GetValue();
            type.GetProperty("RowStatus").SetValue(entity, DB_ROW_STATUS.ADDED.ToString());
       //    type.GetProperty("UniqueId").SetValue(entity, Guid.NewGuid().ToString());
            this.RepositoryContext.Set<T>().Add(entity);
            return entity;
        }

        public T Update(T entity)
        {
            Type type = entity.GetType();
            type.GetProperty("UpdatedDateTime").SetValue(typeof(DateTime), DateTime.Now);
            type.GetProperty("RowStatus").SetValue(entity, DB_ROW_STATUS.UPDATED.ToString());
            this.RepositoryContext.Set<T>().Update(entity);
            return entity;
        }

        public T Delete(T entity)
        {
            Type type = entity.GetType();
            type.GetProperty("UpdatedDateTime").SetValue(entity, DateTime.Now);
            type.GetProperty("RowStatus").SetValue(entity, DB_ROW_STATUS.DELETED.ToString());
            this.RepositoryContext.Set<T>().Update(entity);
            return entity;
        }
    }
}
