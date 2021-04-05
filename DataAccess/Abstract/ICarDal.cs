using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarInfoDto> GetCarDetails(Expression<Func<CarInfoDto, bool>> filter = null);
        List<CarInfoDto> GetCarsInfoByBrandId(int brandId);
        List<CarImagesDto> GetCarImageDetails(Expression<Func<Car, bool>> filter = null);
        List<CarInfoDto> GetCarsInfoByColorId(int colorId);
    }
}
