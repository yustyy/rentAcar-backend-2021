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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, TestDBContext>, IRentalDal
    {
        public List<RentalInfoDto> GetRentalInfo()
        {
            using (TestDBContext context = new TestDBContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join cu in context.Customers
                             on r.CustomerId equals cu.CustomerId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join u in context.Users
                             on cu.UserId equals u.Id
                             select new RentalInfoDto
                             {
                                 BrandName = b.Name,
                                 ColorName = co.Name,
                                 CompanyName = cu.CompanyName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear,
                                 RentalId = r.RentalId,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 UserLastName = u.LastName,
                                 UserName = u.FirstName,
                                 UserMail = u.Email
                             };

                return result.ToList();


            }
        }
    }
}
