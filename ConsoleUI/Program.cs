using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICarService carService = new CarManager(new InMemoryCarDal());

            //foreach (var car in carService.GetAllByBrandId(3)) 
            //{
            //    Console.WriteLine(car.Description);
            //}

            //Console.WriteLine("--------------EKLENDİKTEN SONRA--------------");

            //Car newCar = new Car() { CarId = 6, Description = "Altıncı Araba", BrandId = 3, ColorId = 2, DailyPrice = 800, ModelYear = 2045 };   

            //carService.Add(newCar);

            //foreach (var car in carService.GetAllByBrandId(3))
            //{
            //    Console.WriteLine(car.Description);
            //}

            ICarService carService = new CarManager(new EfCarDal());

            //Car araba1 = new Car() { BrandId = 3, ColorId = 5, DailyPrice = 0, Description = "2012 Model mor Volvo 950 lira", ModelYear = 2030 };

            //carService.Add(araba1);

            Console.WriteLine("Araba idsi 3 olan arabalar");
            foreach (var car in carService.GetCarsByBrandId(3))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("Renk idsi 5 olan arabalar");
            foreach (var car in carService.GetCarsByColorId(5))
            {
                Console.WriteLine(car.Description);
            }

        }
    }
}
