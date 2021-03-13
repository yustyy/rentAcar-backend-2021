using Business.Abstract;
using Business.Constants;
using Core.Utilities.ImageUploader;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        ICarService _carService;
        IFileService _fileService;

        public CarImageManager(ICarImageDal carImageDal, ICarService carService, IFileService fileService)
        {
            _carImageDal = carImageDal;
            _carService = carService;
            _fileService = fileService;
        }

        public IResult Add(int id, IFormFile formFile)
        {
            //business codes

            string fileName = Guid.NewGuid().ToString();

            var image = new CarImage
            {
                CarId = id,
                Date = DateTime.UtcNow,
                ImagePath = fileName
            };

            _carImageDal.Add(image);
            var result = _fileService.Upload(fileName, formFile);


            return new SuccessResult(Messages.CarImageAdded);
        }


        public IResult Delete(int id)
        {
            var currentCar = GetById(id).Data;
            _carImageDal.Delete(currentCar);

            _fileService.Delete(currentCar.ImagePath);
            return new SuccessResult(Messages.CarImageDeleted);

        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(carImage => carImage.CarImageId == id));
        }

    }
}
