﻿using System;
using Crispy_Waddle_Console.Application;
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
            services.AddSingleton<IPhotoAlbumApplication, PhotoAlbumApplication>();
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
