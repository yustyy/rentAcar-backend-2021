using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.ImageUploader
{
    public interface IFileService
    {
        public Task<IResult> Upload(string fileName, IFormFile file);

        public IResult Delete(string path);
    }
}
