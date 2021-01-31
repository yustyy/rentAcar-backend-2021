using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarManager(new InMemoryCarDal());

            foreach (var car in carService.GetAllByBrandId(3)) 
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("--------------EKLENDİKTEN SONRA--------------");

            Car newCar = new Car() { CarId = 6, Description = "Altıncı Araba", BrandId = 3, ColorId = 2, DailyPrice = 800, ModelYear = 2045 };   

            carService.Add(newCar);

            foreach (var car in carService.GetAllByBrandId(3))
            {
                Console.WriteLine(car.Description);
            }

        }
    }
}
