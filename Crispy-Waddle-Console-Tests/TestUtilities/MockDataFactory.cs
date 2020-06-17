using System.Collections.Generic;
using System.IO;
using Crispy_Waddle_Console.Application.Models;
using Newtonsoft.Json;

namespace Crispy_Waddle_Console_Tests.TestUtilities
{
    public static class MockDataFactory
    {
        public static string GetAllMockDataAsString()
        {
            return JsonConvert.SerializeObject(MockedPhotos.Get());
        }

        public static List<Photo> GetAllMockDataAsListOfPhotos()
        {
            return MockedPhotos.Get();
        }

        public static List<Photo> GetAllMockDataAsListOfPhotosByAlbumId(int albumId)
        {
            var photos = MockedPhotos.Get();
            return photos.FindAll(photo => photo.AlbumId == albumId);
        }

        public static string GetAllMockDataAsStringByAlbumId(int albumId)
        {
            var photos = MockedPhotos.Get();
            return JsonConvert.SerializeObject(photos.FindAll(photo => photo.AlbumId == albumId));
        }

    }
}
