using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        public IResult Add(int id, IFormFile file);
        public IResult Delete(int id);
        public IDataResult<CarImage> GetById(int id);
        public IDataResult<List<CarImage>> GetAll();
    }
}
