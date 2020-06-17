using System;
using System.Collections.Generic;
using Crispy_Waddle_Console.Models;

namespace Crispy_Waddle_Console.Data
{
    public class PhotoAlbumRetriever
    {
        public PhotoAlbumRetriever()
        {

        }

        public List<Photo> GetPhotos() {
            return new List<Photo>() { new Photo() };
        }
    }
}
