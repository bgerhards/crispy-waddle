using System;
using Crispy_Waddle_Core.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Crispy_Waddle_Core
{
    public class CoreServices: IServices
    {

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddTransient<IHttpHandler, HttpClientHandler>();
            services.AddTransient<IPhotoAlbumRetriever, PhotoAlbumRetriever>();
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
