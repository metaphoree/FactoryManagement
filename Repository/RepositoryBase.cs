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
        public FactoryManagementContext RepositoryContext { get; set; }

        public RepositoryBase(FactoryManagementContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }
        public async Task<long> NumOfRecord()
        {
            return await RepositoryContext.Set<T>().AsQueryable().CountAsync();
        }
        public async Task<string> GetUniqueId()
        {
            int countOfRows =  await RepositoryContext.Set<T>().AsQueryable().CountAsync();
            return typeof(T).Name.ToUpper() + countOfRows;
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

            PropertyInfo? prop = type.GetProperty("CreatedDateTime");
            PropertyInfo? prop8 = type.GetProperty("CreatedDateTime");

            //type.GetProperty()
            type.GetProperty("CreatedDateTime").SetValue(entity, DateTime.Now);
            type.GetProperty("UpdatedDateTime").SetValue(entity, DateTime.Now);
            type.GetProperty("Id").SetValue(entity, Guid.NewGuid().ToString());
            type.GetProperty("RowStatus").SetValue(entity, DB_ROW_STATUS.ADDED.ToString());
            this.RepositoryContext.Set<T>().Add(entity);
            return entity;
        }
        public List<T> CreateAll(List<T> entityList)
        {
            for (int i = 0;i< entityList.Count;i++ ) {
                Type type = entityList[i].GetType();

                PropertyInfo? prop = type.GetProperty("CreatedDateTime");
                PropertyInfo? prop8 = type.GetProperty("CreatedDateTime");

                //type.GetProperty()
                type.GetProperty("CreatedDateTime").SetValue(entityList[i], DateTime.Now);
                type.GetProperty("UpdatedDateTime").SetValue(entityList[i], DateTime.Now);
                type.GetProperty("Id").SetValue(entityList[i], Guid.NewGuid().ToString());
                type.GetProperty("RowStatus").SetValue(entityList[i], DB_ROW_STATUS.ADDED.ToString());
                this.RepositoryContext.Set<T>().Add(entityList[i]);
            }
            return entityList;
        }
        public T Update(T entity)
        {
            Type type = entity.GetType();
            type.GetProperty("UpdatedDateTime").SetValue(entity, DateTime.Now);
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
        public async Task<int> SaveChangesAsync()
        {
            return await RepositoryContext.SaveChangesAsync();
        }
    }
}
