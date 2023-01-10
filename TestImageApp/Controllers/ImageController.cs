using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TestImageApp.Models;
using TestImageApp.Repository;

namespace TestImageApp.Controllers
{
    public class ImageController : Controller
    {
        IImageRepository _imageRepository;
        public ImageController(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }
        [HttpPost]
        [Route("AddImage")]
        public IActionResult UploadImage()
        {
            var Files = Request.Form.Files;
            var file = Files.FirstOrDefault();
            using (var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                var fileBytes = ms.ToArray();
                var id = Guid.NewGuid().ToString();
                _imageRepository.AddImage(new Image {Id=Guid.NewGuid().ToString(),ImageData= fileBytes, Name= Files.FirstOrDefault().Name });
            }
            
            return Ok();
        }
        [HttpGet]
        [Route("GetImages")]
        public List<Image> GetImages()
        {
            var files = _imageRepository.GetImages();
            return files;
        }
    }
}
