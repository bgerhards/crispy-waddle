using System.Collections.Generic;
using System.Threading.Tasks;
using Crispy_Waddle_Common.Models;

namespace Crispy_Waddle_Core.Data
{
    public interface IPhotoAlbumRetriever
    {
        List<Photo> GetPhotos();
        Task<List<Photo>> GetPhotosByAlbumIdAsync( int albumId);
    }
}
