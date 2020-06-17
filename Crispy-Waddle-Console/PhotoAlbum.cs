using System.Threading.Tasks;
using Crispy_Waddle_Console.Application;
using Microsoft.Extensions.DependencyInjection;

namespace Crispy_Waddle_Console
{
    public class PhotoAlbum
    {
        public static async Task Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            var serviceProvider = Services.ConfigureServices(serviceCollection);

            var scope = serviceProvider.CreateScope();
            await scope.ServiceProvider.GetRequiredService<IPhotoAlbumApplicationHandler>().StartAsync();

            Services.DisposeServices(serviceCollection);
        }
    }
}
