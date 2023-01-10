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
                //string directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DateTime.Now.ToString());
                //if (!Directory.Exists(directory))
                //{
                //    Directory.CreateDirectory(directory);
                //}
                //string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,file.FileName);
                //using (Stream filee = System.IO.File.Open(filePath,FileMode.OpenOrCreate)) 
                //{
                //    filee.Write(fileBytes, 0, fileBytes.Length);
                //}
                //ms.WriteTo
                
                //string s = Convert.ToBase64String(fileBytes);
                // act on the Base64 data
                _imageRepository.AddImage(new Image {Id=Guid.NewGuid().ToString(),ImageData= fileBytes, Name= Files.FirstOrDefault().Name });
            }
            
            return Ok();
        }
        [HttpGet]
        [Route("GetImages")]
        public List<Image> GetImages()
        {
            //var files = new List<Image>();
            var files = _imageRepository.GetImages();
            //foreach(var file in _imageRepository.GetImages())
            //{
            //    var content = file.ImageData ?? new byte[0] ;
            //    files.Add(File(content, "image/jpeg"));
            //    //files.Add(file.ImageData);
            //    //using (Stream filee = System.IO.File.OpenWrite(@"C:\Users\Hamza Rahman\source\repos\TestImageApp\TestImageApp\ClientApp\here.jpeg"))
            //    //{
            //    //    filee.Write(file.ImageData, 0, file.ImageData.Length);
            //    //}
            //}
            return files;
        }
    }
}
