using System;
using System.Collections.Generic;
using Crispy_Waddle_Console.Data;
using Crispy_Waddle_Console.Models;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;

namespace Crispy_Waddle_Console_Tests.Data
{
    public class PhotoAlbumRetrieverTests
    {
        IPhotoAlbumRetriever _photoAlbumRetriever;
        IServiceProvider _serviceProvider;

        public PhotoAlbumRetrieverTests()
        {
            var serviceCollection = new ServiceCollection();
            TestServices.ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider(true);
            _photoAlbumRetriever = _serviceProvider.GetService<IPhotoAlbumRetriever>();
        }

        [Fact]
        public void ReturnPhotos()
        {
            IEnumerable<Photo> photos = _photoAlbumRetriever.GetPhotos();

            Assert.NotEmpty(photos);
        }

        [Fact]
        public void ReturnsPhotosOnlyForTheRequestedAlbumById1()
        {
            var albumId = "1";
            List<Photo> photos = _photoAlbumRetriever.GetPhotosByAlbumId(albumId);

            Assert.NotEmpty(photos);
            Assert.Equal(albumId, photos[0].AlbumId);
        }
    }
}
