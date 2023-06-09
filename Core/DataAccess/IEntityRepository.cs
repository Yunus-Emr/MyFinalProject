using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // generic constraint 
    // class : Referans tip 
    // IEntity: IEntity olabilir veya IEntity iplemente eden bir nesne olabilir
    // new() : new'lenebilir olmalı  
                                          // Kural koyarız where ile hangi değerleri göndermek için
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
