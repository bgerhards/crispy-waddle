using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Crispy_Waddle_Console.Models;

namespace Crispy_Waddle_Console.Data
{
    public interface IPhotoAlbumRetriever
    {
        List<Photo> GetPhotos();
        Task<List<Photo>> GetPhotosByAlbumIdAsync( int albumId);
    }
}
