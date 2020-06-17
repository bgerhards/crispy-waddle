﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using Crispy_Waddle_Console.Models;

namespace Crispy_Waddle_Console.Data
{
    public class PhotoAlbumRetriever: IPhotoAlbumRetriever
    {
        IHttpHandler _httpHandler;

        public PhotoAlbumRetriever(IHttpHandler httpHandler){
            _httpHandler = httpHandler;
        }

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
