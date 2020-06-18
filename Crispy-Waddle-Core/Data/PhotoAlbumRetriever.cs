using System.Collections.Generic;
using Crispy_Waddle_Common.Data;
using Crispy_Waddle_Common.Models;

namespace Crispy_Waddle_Core.Data
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

        public async System.Threading.Tasks.Task<List<Photo>> GetPhotosByAlbumIdAsync(int albumId)
        {
            return await _httpHandler.Get<List<Photo>>(GetUrlWithAlbumId(albumId));
        }

        private string GetUrl()
        {
            return "https://jsonplaceholder.typicode.com/photos";
        }

        private string GetUrlWithAlbumId(int albumId)
        {
            return $"{GetUrl()}?albumId={albumId}";
        }
    }
}
