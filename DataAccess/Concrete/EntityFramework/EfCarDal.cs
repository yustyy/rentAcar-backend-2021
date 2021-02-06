using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (TestDBContext context = new TestDBContext())
            {
                context.Cars.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (TestDBContext context = new TestDBContext())
            {
                var deletedEntity = context.Cars.SingleOrDefault(p => p.CarId == entity.CarId);
                context.Cars.Remove(deletedEntity);
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (TestDBContext context = new TestDBContext())
            {
                return context.Cars.SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (TestDBContext context = new TestDBContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (TestDBContext context = new TestDBContext())
            {
                var updatedEntity = context.Cars.SingleOrDefault(p => p.CarId == entity.CarId);
                updatedEntity.BrandId = entity.BrandId;
                updatedEntity.ColorId = entity.ColorId;
                updatedEntity.DailyPrice = entity.DailyPrice;
                updatedEntity.Description = entity.Description;
                updatedEntity.ModelYear = entity.ModelYear;
                context.SaveChanges();
            }
        }
    }
}
