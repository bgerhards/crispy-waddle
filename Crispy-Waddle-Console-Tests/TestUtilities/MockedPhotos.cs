using System;
using System.Collections.Generic;
using Crispy_Waddle_Console.Models;

namespace Crispy_Waddle_Console_Tests.TestUtilities
{
    public static class MockedPhotos
    {
        public static List<Photo> Get()
        {
            return new List<Photo>()
            {
                new Photo()
                  {
                    AlbumId= 1,
                    Id = 1,
                    Title = "Album Title Uno",
                    Url = "https://via.placeholder.com/600/92c952",
                    ThumbnailUrl = "https://via.placeholder.com/150/92c952"
                  },

                new Photo(){
                    AlbumId= 1,
                    Id = 2,
                    Title = "reprehenderit est deserunt velit ipsam",
                    Url = "https://via.placeholder.com/600/771796",
                    ThumbnailUrl = "https://via.placeholder.com/150/771796"
                  },

                new Photo(){
                    AlbumId= 2,
                    Id = 3,
                    Title = "Album Title Dos",
                    Url = "https://via.placeholder.com/600/24f355",
                    ThumbnailUrl = "https://via.placeholder.com/150/24f355"
                  },

                new Photo(){
                    AlbumId= 3,
                    Id = 4,
                    Title = "culpa odio esse rerum omnis laboriosam voluptate repudiandae",
                    Url = "https://via.placeholder.com/600/d32776",
                    ThumbnailUrl = "https://via.placeholder.com/150/d32776"
                  },

                new Photo(){
                    AlbumId= 3,
                    Id = 5,
                    Title = "natus nisi omnis corporis facere molestiae rerum in",
                    Url = "https://via.placeholder.com/600/f66b97",
                    ThumbnailUrl = "https://via.placeholder.com/150/f66b97"
                  },

                new Photo(){
                    AlbumId= 4,
                    Id = 6,
                    Title = "accusamus ea aliquid et amet sequi nemo",
                    Url = "https://via.placeholder.com/600/56a8c2",
                    ThumbnailUrl = "https://via.placeholder.com/150/56a8c2"
                  },

                new Photo(){
                    AlbumId= 4,
                    Id = 7,
                    Title = "officia delectus consequatur vero aut veniam explicabo molestias",
                    Url = "https://via.placeholder.com/600/b0f7cc",
                    ThumbnailUrl = "https://via.placeholder.com/150/b0f7cc"
                  }
                };
        }
    }
}
