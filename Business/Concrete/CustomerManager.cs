using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer entity)
        {
            _customerDal.Add(entity);

            return new SuccessResult(Messages.CustomerAdded);
        }

        [SecuredOperation("customer.delete,moderator,admin")]
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Delete(Customer entity)
        {
            _customerDal.Delete(entity);

            return new SuccessResult(Messages.CustomerDeleted);
        }

        [SecuredOperation("customer.get,moderator,admin")]
        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomersListed);
        }

        [SecuredOperation("customer.get,moderator,admin")]
        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.Id == id),Messages.UserListed);
        }

        [SecuredOperation("customer.get,moderator,admin")]
        public IDataResult<List<Customer>> GetByUserId(int userId)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.UserId == userId), Messages.CustomersListed);
        }

        [SecuredOperation("customer.update,moderator,admin")]
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Update(Customer entity)
        {
            _customerDal.Update(entity);

            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
