﻿using Survey.Entity.Abstract;
using Survey.Business.Abstract;
using Survey.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Business.Concrete
{
    public class BaseManager<T> : IBaseManager<T> where T : BaseEntity
    {
        private readonly IBaseRepository<T> repository;

        public BaseManager(IBaseRepository<T> repository)
        {

            this.repository = repository;
        }

        #region Insert
        public virtual async Task<int> InsertAsync(T entity)
        {

            return await repository.InsertAsync(entity);
        }
        #endregion

        #region Update
        public virtual async Task<int> UpdateAsync(T entity)
        {
            return await repository.UpdateAsync(entity);
        }
        #endregion

        #region Delete
        public async Task<int> DeleteAsync(T entity)
        {
            return await repository.DeleteAsync(entity);
        }
        #endregion

        #region GetByIdAsync
        public async Task<T?> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }
        #endregion

        #region GetBy
        public async Task<T?> GetBy(Expression<Func<T, bool>> filter)
        {
            return await repository.GetBy(filter);
        }
        #endregion

        #region GetAllAsync
        public async Task<ICollection<T>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null)
        {
            return await repository.GetAllAsync(filter);
        }
        #endregion

        #region GetAllInclude
        public async Task<IQueryable<T>> GetAllInclude(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] include)
        {
            return await repository.GetAllInclude(filter, include);
        }
        #endregion
    }
}
