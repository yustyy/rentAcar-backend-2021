using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car entity);
        IResult Update(Car entity);
        IResult Delete(Car entity);

        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);


        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<CarInfoDto>> GetCarsInfoByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<Car>> GetCarsByModelYear(int modelYear);
        IDataResult<List<Car>> GetCarsByDailyPrice(int dailyPrice);
        IDataResult<List<CarInfoDto>> GetCarsInfo();
        IDataResult<List<CarImagesDto>> GetAllImagesById(int id);
        IResult AddTransactionalTest(Car car);
        IDataResult<List<CarInfoDto>> GetCarsInfoByColorId(int colorId);
    }
}
