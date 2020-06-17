﻿using System;
using System.Threading.Tasks;
using Crispy_Waddle_Console.Data;
using Crispy_Waddle_Console.Models;

namespace Crispy_Waddle_Console
{
    public class PhotoAlbumApplication : IPhotoAlbumApplication
    {
        private readonly IPhotoAlbumRetriever _photoAlbumRetriever;

        public PhotoAlbumApplication(IPhotoAlbumRetriever photoAlbumRetriever)
        {
            _photoAlbumRetriever = photoAlbumRetriever;
        }

        public async Task StartAsync()
        {
            PrintIntroduction();
            await BeginApplication();

        }

        private async Task BeginApplication() {
            string albumNumber = RequestAlbumNumber();

            if (ValidAlbumNumber(albumNumber))
            {
                await DisplayContentsOfAlbum(albumNumber);
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

        private async Task DisplayContentsOfAlbum(string albumNumber)
        {
            var albumIdAsInt = int.Parse(albumNumber);
            var photos = await _photoAlbumRetriever.GetPhotosByAlbumIdAsync(albumIdAsInt);

            photos.ForEach(photo => Console.WriteLine(photo.ToString()));
        }

        private void PrintIntroduction()
        {
            Console.WriteLine("Welcome to your Photo Album");
        }

        private bool ValidAlbumNumber(string albumNumber)
        {
            int.TryParse(albumNumber, out int parsedResult);
            return parsedResult >= 1 && parsedResult <= 100;
        }

        private string RequestAlbumNumber()
        {
            Console.WriteLine("Please enter the album number [1-100] to view it's contents");
            return Console.ReadLine();
        }
    }
}
