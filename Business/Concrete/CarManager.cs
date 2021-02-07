using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car entity)
        {
            if (entity.Description.Length >= 2 && entity.DailyPrice > 0)
            {
                _carDal.Add(entity);
            }
            else
            {
                Console.WriteLine("Bir hata oluştu lütfen girdiğiniz değerleri kontrol ediniz!");
            }
            
        }

        public void Delete(Car entity)
        {
            _carDal.Delete(entity);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.CarId == id);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByDailyPrice(int dailyPrice)
        {
            return _carDal.GetAll(c => c.DailyPrice == dailyPrice);
        }

        public List<Car> GetCarsByModelYear(int modelYear)
        {
            return _carDal.GetAll(c => c.ModelYear == modelYear);
        }

        public void Update(Car entity)
        {
            _carDal.Update(entity);
        }

        public List<CarInfoDto> GetCarInfo()
        {
            return _carDal.GetCarDetails();
        }
    }
}
