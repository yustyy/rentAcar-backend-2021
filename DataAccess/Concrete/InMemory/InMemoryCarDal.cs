using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=400,Description="Birinci araba",ModelYear=2008 },
                new Car{CarId=2,BrandId=1,ColorId=1,DailyPrice=600,Description="İkinci araba",ModelYear=2011 },
                new Car{CarId=3,BrandId=3,ColorId=4,DailyPrice=1600,Description="Üçüncü araba",ModelYear=2021 },
                new Car{CarId=4,BrandId=2,ColorId=4,DailyPrice=1400,Description="Dördüncü araba",ModelYear=2020 },
                new Car{CarId=5,BrandId=3,ColorId=7,DailyPrice=1800,Description="Beşinci araba",ModelYear=2030 }
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public List<Car> GetAllByDailyPrice(int dailyPrice)
        {
            return _cars.Where(c => c.DailyPrice == dailyPrice).ToList();
        }

        public List<Car> GetAllByModelYear(int modelYear)
        {
            return _cars.Where(c => c.ModelYear == modelYear).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
