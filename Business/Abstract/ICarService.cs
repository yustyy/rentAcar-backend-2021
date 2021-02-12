using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService:IEntityServiceRepository<Car>
    {
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<Car>> GetCarsByModelYear(int modelYear);
        IDataResult<List<Car>> GetCarsByDailyPrice(int dailyPrice);

        IDataResult<List<CarInfoDto>> GetCarInfo();
    }
}
