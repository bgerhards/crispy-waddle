using System;
using System.Threading.Tasks;
using Crispy_Waddle_Console.Application.Prompts;

namespace Crispy_Waddle_Console.Application
{
    public class PhotoAlbumApplicationHandler : IPhotoAlbumApplicationHandler
    {
        private readonly RequestAlbumNumber _requestAlbumNumber;
        private readonly Introduction _introduction;

        public PhotoAlbumApplicationHandler(RequestAlbumNumber requestAlbumNumber, Introduction introduction)
        {
            _requestAlbumNumber = requestAlbumNumber;
            _introduction = introduction;
        }

        public async Task StartAsync()
        {
            _introduction.Display();
            await MainLoop();
        }

        public async Task MainLoop()
        {
            await _requestAlbumNumber.DisplayAsync();
            await ViewMoreContents();
        }

        public async Task ViewMoreContents()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to view contents of another album? [y/n]");
            var userResponse = Console.ReadLine();
            if (UserWantsToViewMoreContents(userResponse))
            {
                Console.Clear();
                await MainLoop();
            }
        }

        private bool UserWantsToViewMoreContents(string userResponse)
        {
            return !string.IsNullOrEmpty(userResponse) && userResponse.Substring(0, 1).ToLower() == "y";
        }
    }
}
