using System.Collections.Generic;
using System.Threading.Tasks;
using Crispy_Waddle_Console.Application.Models;

namespace Crispy_Waddle_Console.Application.Data
{
    public interface IPhotoAlbumRetriever
    {
        List<Photo> GetPhotos();
        Task<List<Photo>> GetPhotosByAlbumIdAsync( int albumId);
    }
}
