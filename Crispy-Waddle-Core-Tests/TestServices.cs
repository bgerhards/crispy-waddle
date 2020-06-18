using Crispy_Waddle_Core;
using Crispy_Waddle_Core.Data;
using Crispy_Waddle_Core_Tests.TestUtilities;
using Microsoft.Extensions.DependencyInjection;

namespace Crispy_Waddle_Core_Tests
{
    public static class TestServices
    {

        public static void ConfigureServices(IServiceCollection services)
        {
            CoreServices.ConfigureServices(services);
            services.AddTransient<IHttpHandler, MockHttpClientHandler>();
        }
    }
}
