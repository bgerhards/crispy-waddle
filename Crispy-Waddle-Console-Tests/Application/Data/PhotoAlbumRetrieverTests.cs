using System;
using System.Collections.Generic;
using Crispy_Waddle_Console.Application.Data;
using Crispy_Waddle_Console.Application.Models;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Crispy_Waddle_Console_Tests.Application.Data
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
        public async System.Threading.Tasks.Task ReturnsPhotosOnlyForTheRequestedAlbumById1Async()
        {
            var albumId = 1;
            List<Photo> photos = await _photoAlbumRetriever.GetPhotosByAlbumIdAsync(albumId);

            Assert.NotEmpty(photos);
            Assert.Equal(albumId, photos[0].AlbumId);
        }

        [Fact]
        public async System.Threading.Tasks.Task ReturnsPhotoTitleAsyncForAlbum1()
        {
            var albumId = 1;
            List<Photo> photos = await _photoAlbumRetriever.GetPhotosByAlbumIdAsync(albumId);

            Assert.NotEmpty(photos);
            Assert.Equal("Album Title Uno", photos[0].Title);
        }

        [Fact]
        public async System.Threading.Tasks.Task ReturnsPhotoTitleAsyncForAlbum2()
        {
            var albumId = 2;
            List<Photo> photos = await _photoAlbumRetriever.GetPhotosByAlbumIdAsync(albumId);

            Assert.NotEmpty(photos);
            Assert.Equal("Album Title Dos", photos[0].Title);
        }

    }
}
