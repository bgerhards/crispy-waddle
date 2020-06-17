using System;
using System.Threading.Tasks;
using Crispy_Waddle_Core.Data;

namespace Crispy_Waddle_Console.Application
{
    public class ContentsDisplayHandler: IContentsDisplayHandler
    {
        private readonly IPhotoAlbumRetriever _photoAlbumRetriever;

        public ContentsDisplayHandler(IPhotoAlbumRetriever photoAlbumRetriever)
        {
            _photoAlbumRetriever = photoAlbumRetriever;
        }

        public async Task DisplayPhotosAsync(string albumNumber)
        {
            var albumIdAsInt = int.Parse(albumNumber);
            var photos = await _photoAlbumRetriever.GetPhotosByAlbumIdAsync(albumIdAsInt);

            photos.ForEach(photo => Console.WriteLine(photo.ToString()));
        }
    }
}
