using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestImageApp.Models;

namespace TestImageApp.Repository
{
    public class ImageRepository : ImageDbContext, IImageRepository
    {
        public async void AddImage(Image Image)
        {
            await Images.AddAsync(Image);
            SaveChanges();
        }

        public List<Image> GetImages()
        {
            return  Images.AsParallel().ToList();
        }
    }
}
