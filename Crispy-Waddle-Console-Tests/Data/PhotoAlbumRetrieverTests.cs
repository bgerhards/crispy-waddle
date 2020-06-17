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
        public void ReturnPhotos()
        {
            IEnumerable<Photo> photos = _photoAlbumRetriever.GetPhotos();

            Assert.NotEmpty(photos);
        }

        [Fact]
        public void ReturnsPhotosOnlyForTheRequestedAlbumById()
        {
            var albumId = "1";
            List<Photo> photos = _photoAlbumRetriever.GetPhotosByAlbumId(albumId);

            Assert.NotEmpty(photos);
            Assert.Equal("1", photos[0].AlbumId);
        }

    }
}
