﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService:IEntityServiceRepository<Customer>
    {
        IDataResult<List<Customer>> GetByUserId(int userId);
    }
}