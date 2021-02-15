using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // generic constraint   
    // class : Buradaki Class referans tipi temsil eder
    // IEntity : IEntity de olabilir Ientity implemente eden class da olabilir
    // new() : New lenebilir olmalı
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);       
    }
}
