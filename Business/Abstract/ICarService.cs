using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService:IEntityServiceRepository<Car>
    {
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        List<Car> GetCarsByModelYear(int modelYear);
        List<Car> GetCarsByDailyPrice(int dailyPrice);

        List<CarInfoDto> GetCarInfo();
    }
}
