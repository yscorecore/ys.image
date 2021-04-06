using System.Threading.Tasks;
namespace YS.Image.Core
{
    public interface IImageService
    {
        Task<string> GetImageUrl(string sourceImageUrl);
    }
}