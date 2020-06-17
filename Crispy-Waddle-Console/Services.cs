using System;
using Crispy_Waddle_Console.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Crispy_Waddle_Console
{
    public static class Services
    {

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddTransient<IHttpHandler, HttpClientHandler>();
            services.AddTransient<IPhotoAlbumRetriever, PhotoAlbumRetriever>();
        }
    }
}
