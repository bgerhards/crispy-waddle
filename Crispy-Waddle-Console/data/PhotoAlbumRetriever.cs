using System;
using System.Collections.Generic;
using Crispy_Waddle_Console.Models;

namespace Crispy_Waddle_Console.Data
{
    public class PhotoAlbumRetriever: IPhotoAlbumRetriever
    {
        public PhotoAlbumRetriever(){}

        public List<Photo> GetPhotos()
        {
            return new List<Photo>() { new Photo() };
        }

        public List<Photo> GetPhotosByAlbumId(string albumId)
        {
            return new List<Photo>() { new Photo() { AlbumId = albumId } };
        }
    }
}
