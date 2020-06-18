using System;
using System.IO;
using System.Threading.Tasks;
using Crispy_Waddle_Console.Application.Prompts;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Crispy_Waddle_Console_Tests.Application.Prompts
{
    public class RequestAlbumNumberTests
    {
        ServiceProvider _serviceProvider;
        RequestAlbumNumber _requestAlbumNumber;
        private string PROMPT_DEFAULT_MESSAGE = "Please enter the album number [1-100] to view it's contents";

        public RequestAlbumNumberTests()
        {
            var serviceCollection = new ServiceCollection();
            ConsoleTestServices.ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider(true);
            _requestAlbumNumber = _serviceProvider.GetService<RequestAlbumNumber>();
        }

        [Fact]
        public async Task PrintsPhotosForAlbum2()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader("2");
            Console.SetIn(input);

            await _requestAlbumNumber.DisplayAsync();

            var outputArray = output.ToString().Split("\n");
            Assert.Equal(3, outputArray.Length);
            Assert.Contains(PROMPT_DEFAULT_MESSAGE, outputArray[0]);
            Assert.Contains("[3] Album Title Dos", outputArray[1]);
            Assert.Contains(string.Empty, outputArray[2]);
        }

        [Fact]
        public async Task PrintsPhotosForAlbum3()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader("3");
            Console.SetIn(input);

            await _requestAlbumNumber.DisplayAsync();

            var outputArray = output.ToString().Split("\n");
            Assert.Equal(4, outputArray.Length);
            Assert.Contains(PROMPT_DEFAULT_MESSAGE, outputArray[0]);
            Assert.Contains("[4] culpa odio esse rerum omnis laboriosam voluptate repudiandae", outputArray[1]);
            Assert.Contains("[5] natus nisi omnis corporis facere molestiae rerum in", outputArray[2]);
            Assert.Contains(string.Empty, outputArray[3]);
        }

    }
}
