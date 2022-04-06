
using Core.Contracts;
using Infrastructure.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(CosmosIdentityFunc.Startup))]

namespace CosmosIdentityFunc
{
    public class Startup: FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddHttpClient();
            builder.Services.AddScoped<IProductService, ProductService>();
        }
    }
}