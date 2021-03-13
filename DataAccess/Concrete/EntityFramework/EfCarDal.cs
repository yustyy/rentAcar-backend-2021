using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, TestDBContext>, ICarDal
    {
        public List<CarInfoDto> GetCarDetails()
        {
            using (TestDBContext context = new TestDBContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarInfoDto
                             {
                                 BrandName = b.Name,
                                 CarId = c.CarId,
                                 ColorName = co.Name,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description
                             };

                return result.ToList();

            }


        }

        public List<CarImagesDto> GetCarImageDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (TestDBContext context = new TestDBContext())
            {
                var result = from c in filter is null 

                             ? context.Cars 
                             : context.Cars.Where(filter)

                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join ci in context.CarImages
                             on c.CarId equals ci.CarId
                             select new CarImagesDto
                             {
                                 BrandName = b.Name,
                                 ColorName = co.Name,
                                 CreatedDate = ci.Date,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ImagePath = ci.ImagePath,
                                 ModelYear = c.ModelYear
                             };

                return result.ToList();

            }
        }
    }
}
