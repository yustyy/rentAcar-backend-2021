using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (TestDBContext context = new TestDBContext())
            {
                context.Colors.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (TestDBContext context = new TestDBContext())
            {
                var removedEntity = context.Colors.SingleOrDefault(p => p.ColorId == entity.ColorId);
                context.Colors.Remove(removedEntity);
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (TestDBContext context = new TestDBContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (TestDBContext context = new TestDBContext())
            {
                return filter == null 
                    ? context.Set<Color>().ToList() // BOŞ İSE BUNU YAP
                    : context.Set<Color>().Where(filter).ToList(); // BOŞ DEĞİL İSE BUNU YAP
            }
        }

        public void Update(Color entity)
        {
            using (TestDBContext context = new TestDBContext())
            {
                var updatedEntity = context.Colors.SingleOrDefault(p => p.ColorId == entity.ColorId);
                updatedEntity.Name = entity.Name;
                context.SaveChanges();
            }
        }
    }
}
