using System;
using Crispy_Waddle_Console;
using Crispy_Waddle_Console.Data;
using Crispy_Waddle_Console_Tests.TestUtilities;
using Microsoft.Extensions.DependencyInjection;

namespace Crispy_Waddle_Console_Tests
{
    public static class TestServices
    {

        public static void ConfigureServices(IServiceCollection services)
        {
            Services.ConfigureServices(services);
            services.AddTransient<IHttpHandler, MockHttpClientHandler>();
        }
    }
}
