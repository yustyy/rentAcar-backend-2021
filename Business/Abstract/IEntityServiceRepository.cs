using Core.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEntityServiceRepository<T> where T:class,IEntity,new()
    {
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);

        IDataResult<List<T>> GetAll();
        IDataResult<T> GetById(int id);
    }
}
