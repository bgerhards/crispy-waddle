using System;
using System.Threading.Tasks;
using Crispy_Waddle_Core;

namespace Crispy_Waddle_Console.Application
{
    public class PhotoAlbumApplicationHandler : IPhotoAlbumApplicationHandler
    {
        private readonly IContentsDisplayHandler _photoAlbumRetriever;

        public PhotoAlbumApplicationHandler(IContentsDisplayHandler contentsDisplayHandler)
        {
            _photoAlbumRetriever = contentsDisplayHandler;
        }

        public async Task StartAsync()
        {
            Introduction.Display();
            await BeginApplication();
        }

        private async Task BeginApplication()
        {
            string albumNumber = RequestAlbumNumber();

            if (AlbumNumberHelper.ValidNumber(albumNumber))
            {
                await _photoAlbumRetriever.DisplayPhotosAsync(albumNumber);
            }
            else
            {
                Console.WriteLine("You did not enter a valid album number [1-100]. Let's try that again.");
            }
            await AskUserToStartOver();
        }

        private async Task AskUserToStartOver()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to view contents of another album? [y/n]");
            var restartApplication = Console.ReadLine();
            if (restartApplication.Substring(0, 1).ToLower() == "y")
            {
                Console.Clear();
                await BeginApplication();
            }
        }

        private string RequestAlbumNumber()
        {
            Console.WriteLine("Please enter the album number [1-100] to view it's contents");
            return Console.ReadLine();
        }
    }
}
