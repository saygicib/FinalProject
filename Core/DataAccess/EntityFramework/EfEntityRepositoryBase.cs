using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity :class, IEntity,new()
        where TContext : DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);//Eklenecek nesnenin referansını almak için yazıldı.
                addedEntity.State = EntityState.Added;//Eklenecek bir nesne.
                context.SaveChanges();//Ekle.
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);//Silinecek nesnenin referansını almak için yazıldı.
                deletedEntity.State = EntityState.Deleted;//Silinecek bir nesne.
                context.SaveChanges();//Sil.
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList(); //Filtre null mı?? Evetse soldaki çalışır
                                                                                                                         //Hayırsa soldaki çalışır.
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                //var updatedEntity = context.Products.SingleOrDefault(p => p.ProductId == entity.ProductId);
                //updatedEntity.ProductId = entity.ProductId;
                //updatedEntity.ProductName = entity.ProductName;
                //updatedEntity.UnitPrice = entity.UnitPrice;
                //updatedEntity.UnitsInStock = entity.UnitsInStock;
                //updatedEntity.CategoryId = entity.CategoryId;

                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
