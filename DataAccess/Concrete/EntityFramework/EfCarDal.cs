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
        public List<CarInfoDto> GetCarDetails(Expression<Func<CarInfoDto, bool>> filter = null)
        {
            using (TestDBContext context = new TestDBContext())
            {
                var result = from p in context.Cars
                             join b in context.Brands
                                 on p.BrandId equals b.Id
                             join c in context.Colors
                                 on p.ColorId equals c.Id
                             select new CarInfoDto
                             {
                                 Id = p.Id,
                                 CarName = p.Name,
                                 BrandName = b.Name,
                                 ColorName = c.Name,
                                 DailyPrice = p.DailyPrice,
                                 ModelYear = p.ModelYear
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

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
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             join ci in context.CarImages
                             on c.Id equals ci.CarId
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

        public List<CarInfoDto> GetCarsInfoByBrandId(int brandId)
        {
            using (TestDBContext context = new TestDBContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             where brandId == c.BrandId
                             select new CarInfoDto
                             {
                                 BrandName = b.Name,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 ColorName = co.Name,
                                 CarName = c.Name
                             };

                return result.ToList();

            }
        }

        public List<CarInfoDto> GetCarsInfoByColorId(int colorId)
        {
            using (TestDBContext context = new TestDBContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             where colorId == c.ColorId
                             select new CarInfoDto
                             {
                                 BrandName = b.Name,
                                 CarName = c.Name,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 ColorName = co.Name
                             };

                return result.ToList();

            }
        }
    }
}
