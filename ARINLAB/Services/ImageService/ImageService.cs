using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace ARINLAB.Services.ImageService
{
    public class ImageService : IImageService
    {
        private readonly IWebHostEnvironment _appEnvironment;

        public ImageService(IWebHostEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }
        public bool DeleteImage(string pictureName)
        {
            string path = _appEnvironment.WebRootPath + "/"+pictureName;

            if (!File.Exists(path)) return false;

            try
            {
                File.Delete(path);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public  async Task<string> UploadImage(IFormFile formFile, string path1)
        {
            var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(formFile.FileName);
            string path = _appEnvironment.WebRootPath + "/Sounds/" + path1+"/";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            using (var fileStream = new FileStream( path + fileName, FileMode.Create))
            {
                await formFile.CopyToAsync(fileStream);
            }

            return $"Sounds/{path1}/{fileName}";
        }
    }
}
