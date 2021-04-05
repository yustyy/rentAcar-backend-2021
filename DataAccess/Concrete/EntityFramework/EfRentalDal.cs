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
                var result = from r in  context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join cu in context.Customers
                             on r.CustomerId equals cu.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join u in context.Users
                             on cu.UserId equals u.Id
                             select new RentalInfoDto
                             {
                                 RentalId = r.Id,
                                 CarName = b.Name,
                                 CustomerName = u.FirstName + " " + u.LastName,
                                 UserName = u.FirstName + " " + u.LastName,
                                 RentDate = r.RentStartDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();


            }
        }
    }
}
