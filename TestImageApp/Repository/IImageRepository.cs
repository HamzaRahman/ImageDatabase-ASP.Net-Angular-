using System.Collections.Generic;
using System.Threading.Tasks;
using TestImageApp.Models;

namespace TestImageApp.Repository
{
    public interface IImageRepository
    {
        void AddImage(Image Image);
        List<Image> GetImages();
    }
}
