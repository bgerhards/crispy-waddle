using System;
using System.Collections.Generic;
using Crispy_Waddle_Console.Data;
using Crispy_Waddle_Console.Models;
using Xunit;

namespace Crispy_Waddle_Console_Tests.Data
{
    public class PhotoAlbumRetrieverTests
    {
        PhotoAlbumRetriever _photoAlbumRetriever;
        public PhotoAlbumRetrieverTests()
        {
            _photoAlbumRetriever = new PhotoAlbumRetriever();
        }

        [Fact]
        public void ReturnPhotos() {
            List<Photo> photos = _photoAlbumRetriever.GetPhotos();

            Assert.NotEmpty(photos);
        }

    }
}
