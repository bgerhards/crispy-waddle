using System;
using System.IO;
using Crispy_Waddle_Console.Application.Prompts;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Crispy_Waddle_Console_Tests.Application.Prompts
{
    public class IntroductionTests
    {
        ServiceProvider _serviceProvider;
        Introduction _introduction;

        public IntroductionTests()
        {
            var serviceCollection = new ServiceCollection();
            ConsoleTestServices.ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider(true);
            _introduction = _serviceProvider.GetService<Introduction>();
        }

        [Fact]
        public void PrintsIntroductionStatement() {
            var output = new StringWriter();
            Console.SetOut(output);

            _introduction.Display();

            Assert.Equal("Welcome to your Photo Album\n", output.ToString());
        }

    }
}
