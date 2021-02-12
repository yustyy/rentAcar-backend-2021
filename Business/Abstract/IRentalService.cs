using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService:IEntityServiceRepository<Rental>
    {
        IDataResult<Rental> GetByCarId(int carId);
        IDataResult<List<Rental>> GetByCustomerId(int customerId);
        IDataResult<List<Rental>> GetByDate(DateTime rentDate, DateTime returnDate);

        IDataResult<List<RentalInfoDto>> GetRentalInfo();

    }
}
