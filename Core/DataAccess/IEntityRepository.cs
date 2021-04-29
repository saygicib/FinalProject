using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic Constraint
    //class : referans tip olmalı demek.
    //IEntity : IEntity veya IEntity implemente eden bir nesne olabilir.
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filte=null);//Burası istediğimiz filtreleme yöntemine göre getirecek.
        T Get(Expression<Func<T,bool>> filter);//Filtre zorunlu.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);    
    }
}
