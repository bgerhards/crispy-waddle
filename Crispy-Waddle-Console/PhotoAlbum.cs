using Crispy_Waddle_Console.Application;
using Microsoft.Extensions.DependencyInjection;

namespace Crispy_Waddle_Console
{
    public class PhotoAlbum
    {
        public static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            var serviceProvider = Services.ConfigureServices(serviceCollection);

            var scope = serviceProvider.CreateScope();
            scope.ServiceProvider.GetRequiredService<IPhotoAlbumApplication>().StartAsync();

            Services.DisposeServices(serviceCollection);
        }
    }
}
