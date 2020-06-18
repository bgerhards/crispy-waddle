using System;
using Crispy_Waddle_Console.Application;
using Crispy_Waddle_Console.Application.Prompts;
using Crispy_Waddle_Core;
using Microsoft.Extensions.DependencyInjection;

namespace Crispy_Waddle_Console
{
    public static class Services
    {

        public static ServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient();
            CoreServices.ConfigureServices(services);
            services.AddTransient<IContentsDisplayHandler, ContentsDisplayHandler>()
                .AddSingleton<IPhotoAlbumApplicationHandler, PhotoAlbumApplicationHandler>()
                .AddTransient<Introduction>()
                .AddTransient< RequestAlbumNumber>();

            return services.BuildServiceProvider(true);
        }

        public static void DisposeServices(IServiceCollection services)
        {

            if (services == null)
            {
                return;
            }
            if (services is IDisposable)
            {
                ((IDisposable)services).Dispose();
            }
        }
    }
}
