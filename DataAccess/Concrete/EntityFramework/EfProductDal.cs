using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    { 
        public void Add(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                    var addedEntity = context.Entry(entity);//Eklenecek nesnenin referansını almak için yazıldı.
                    addedEntity.State = EntityState.Added;//Eklenecek bir nesne.
                    context.SaveChanges();//Ekle.
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);//Silinecek nesnenin referansını almak için yazıldı.
                deletedEntity.State = EntityState.Deleted;//Silinecek bir nesne.
                context.SaveChanges();//Sil.
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList(); //Filtre null mı?? Evetse soldaki çalışır
                                                                                                                         //Hayırsa soldaki çalışır.
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);//Eklenecek nesnenin referansını almak için yazıldı.
                updatedEntity.State = EntityState.Modified;//Eklenecek bir nesne.
                context.SaveChanges();
            }
        }
    }
}
