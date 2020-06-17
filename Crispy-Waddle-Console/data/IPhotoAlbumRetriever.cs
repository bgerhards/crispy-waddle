using System;
using System.Collections.Generic;
using Crispy_Waddle_Console.Models;

namespace Crispy_Waddle_Console.Data
{
    public interface IPhotoAlbumRetriever
    {
        List<Photo> GetPhotos();
        List<Photo> GetPhotosByAlbumId( string albumId);
    }
}
