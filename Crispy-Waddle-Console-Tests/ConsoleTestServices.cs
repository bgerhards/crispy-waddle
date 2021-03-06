﻿using System;
using Crispy_Waddle_Common.Data;
using Crispy_Waddle_Common.TestUtilities;
using Crispy_Waddle_Console;
using Microsoft.Extensions.DependencyInjection;

namespace Crispy_Waddle_Console_Tests
{
    public static class ConsoleTestServices
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            ConsoleServices.ConfigureServices(services);
            services.AddTransient<IHttpHandler, MockHttpClientHandler>();
        }
    }

}