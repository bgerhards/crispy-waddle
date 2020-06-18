using System;
using System.Threading.Tasks;
using Crispy_Waddle_Core;

namespace Crispy_Waddle_Console.Application.Prompts
{
    public class RequestAlbumNumber
    {
        private readonly IContentsDisplayHandler _contentsDisplayHandler;

        public RequestAlbumNumber(IContentsDisplayHandler contentsDisplayHandler)
        {
            _contentsDisplayHandler = contentsDisplayHandler;
        }

        public async Task DisplayAsync() {
            Console.WriteLine("Please enter the album number [1-100] to view it's contents");
            var albumNumber =  Console.ReadLine();

            if (AlbumNumberHelper.ValidNumber(albumNumber))
            {
                await _contentsDisplayHandler.DisplayPhotosAsync(albumNumber);
            }
            else
            {
                Console.WriteLine("You did not enter a valid album number [1-100]. Let's try that again.");
            }
        }

    }
}
