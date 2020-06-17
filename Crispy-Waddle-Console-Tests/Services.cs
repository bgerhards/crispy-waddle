using System;
using Crispy_Waddle_Console;
using Crispy_Waddle_Console.Application;
using Crispy_Waddle_Console.Application.Data;
using Crispy_Waddle_Console_Tests.TestUtilities;
using Microsoft.Extensions.DependencyInjection;

namespace Crispy_Waddle_Console_Tests.Application
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
