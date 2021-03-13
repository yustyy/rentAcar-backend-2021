using Core.Utilities.Results;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.ImageUploader
{
    public class FileManager : IFileService
    {

        IHostingEnvironment _environment;
        string fileDirectory;

        public FileManager(IHostingEnvironment  environment)
        {
            _environment = environment;
            var fileDirectory = environment.ContentRootPath + "/images/";
        }

        public IResult Delete(string path)
        {
            var deletedFile = Path.Combine(fileDirectory + path + ".png");
            if (deletedFile!=null)
            {
                File.Delete(deletedFile);
            }

            return new SuccessResult("Fotoğraf silindi!");

        }

        public async Task<IResult> Upload(string fileName, IFormFile file)
        {
            using (var fileStream = new FileStream(Path.Combine(fileDirectory + fileName + file + ".png"), FileMode.Create, FileAccess.Write))
            {
                await file.CopyToAsync(fileStream);
            }

            return new SuccessResult("Fotoğraf yüklendi!");
        }
    }
}
