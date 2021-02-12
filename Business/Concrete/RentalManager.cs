using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental entity)
        {
                _rentalDal.Add(entity);

                return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental entity)
        {
            _rentalDal.Delete(entity);

            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalsListed);
        }

        public IDataResult<Rental> GetByCarId(int carId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.CarId == carId), Messages.RentalListed);
        }

        public IDataResult<List<Rental>> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CustomerId == customerId), Messages.RentalsListed);
        }

        public IDataResult<List<Rental>> GetByDate(DateTime rentDate, DateTime returnDate)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.RentDate >= rentDate && r.ReturnDate <= returnDate), Messages.RentalsListed);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentalId == id), Messages.RentalListed);
        }

        public IDataResult<List<RentalInfoDto>> GetRentalInfo()
        {
            return new SuccessDataResult<List<RentalInfoDto>>(_rentalDal.GetRentalInfo(),Messages.RentalsListed);
        }

        public IResult Update(Rental entity)
        {
            _rentalDal.Update(entity);

            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
