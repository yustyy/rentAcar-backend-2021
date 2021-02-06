using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (TestDBContext context = new TestDBContext())
            {
                context.Brands.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (TestDBContext context = new TestDBContext())
            {
                var removedEntity = context.Brands.SingleOrDefault(p=>p.BrandId == entity.BrandId);
                context.Brands.Remove(removedEntity);
                context.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (TestDBContext context = new TestDBContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (TestDBContext context = new TestDBContext())
            {
                return filter == null
                    ? context.Set<Brand>().ToList()
                    : context.Set<Brand>().Where(filter).ToList();
            }
            
        }

        public void Update(Brand entity)
        {
            using (TestDBContext context = new TestDBContext())
            {
                var updatedEntity = context.Brands.SingleOrDefault(p => p.BrandId == entity.BrandId);
                updatedEntity.Name = entity.Name;
                context.SaveChanges();
            }
        }
    }
}
