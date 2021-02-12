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
            //TEST1();
            //TEST2();
            //YeniKullanıcı();

            IRentalService rentalService = new RentalManager(new EfRentalDal());
            rentalService.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = DateTime.Now,ReturnDate=DateTime.MaxValue});

            foreach (var result in rentalService.GetRentalInfo().Data)
            {
                Console.WriteLine(result.RentalId+" / "+result.BrandName+" / "+result.ColorName+" / "+result.ModelYear+" / "
                    +result.DailyPrice+" / "+result.Description+" / "+result.UserName+" / "+result.UserLastName+" / "
                    +result.UserMail+" / "+result.CompanyName+" / "+result.RentDate+" / "+result.ReturnDate);
            }

        }

        private static void YeniKullanıcı()
        {
            IUserService userService = new UserManager(new EfUserDal());
            userService.Add(new User { Email = "yusuf.acmaci@hotmail.com", FirstName = "Yusuf", LastName = "Açmacı", Password = "sifre123" });

            foreach (var user in userService.GetAll().Data)
            {
                Console.WriteLine(user.FirstName);
            }
        }

        private static void TEST2()
        {
            ICarService carService = new CarManager(new EfCarDal());
            var result = carService.GetCarInfo();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + " / " + car.BrandName + " / " + car.ColorName + " / " + car.ModelYear + " / " + car.DailyPrice + " / " + car.Description);
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void TEST1()
        {
            ICarService carService = new CarManager(new InMemoryCarDal());

            foreach (var car in carService.GetCarsByBrandId(3).Data)
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("--------------EKLENDİKTEN SONRA--------------");

            Car newCar = new Car() { CarId = 6, Description = "Altıncı Araba", BrandId = 3, ColorId = 2, DailyPrice = 800, ModelYear = 2045 };

            carService.Add(newCar);

            foreach (var car in carService.GetCarsByBrandId(3).Data)
            {
                Console.WriteLine(car.Description);
            }

            ICarService carService1 = new CarManager(new EfCarDal());

            Car araba1 = new Car() { BrandId = 3, ColorId = 5, DailyPrice = 0, Description = "2012 Model mor Volvo 950 lira", ModelYear = 2030 };

            carService1.Add(araba1);

            Console.WriteLine("Araba idsi 3 olan arabalar");
            foreach (var car in carService1.GetCarsByBrandId(3).Data)
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("Renk idsi 5 olan arabalar");
            foreach (var car in carService1.GetCarsByColorId(5).Data)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
