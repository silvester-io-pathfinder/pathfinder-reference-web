using Blazored.LocalStorage;
using Fluxor;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using Silvester.Pathfinder.Official.Web.Services;
using Silvester.Pathfinder.Official.Web.Services.Currencies;
using Silvester.Pathfinder.Official.Web.Store.Middlewares;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            WebAssemblyHostBuilder builder = WebAssemblyHostBuilder
                .CreateDefault(args);
            
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddMudServices();
            builder.Services.AddFluxor(options =>
            {
                options
                    .ScanAssemblies(typeof(Program).Assembly)
                    .AddMiddleware<LoggingMiddleware>()
                    .AddMiddleware<StatePersistingMiddleware>()
                    .AddMiddleware<StateLoadingMiddleware>();
            });
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddScoped<IClipboardService, ClipboardService>();
            builder.Services.AddScoped<IBreakpointService, BreakpointService>();
            builder.Services.AddScoped<ICurrencyService, CurrencyService>();
            builder.Services.AddScoped<IActionTypeService, ActionTypeService>();
            builder.Services.AddScoped(sp => new HttpClient
            { 
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            });
            builder.Services.AddPathfinderOfficialApi();
            builder.Services
                .AddHttpClient(PathfinderOfficialApi.ClientName)
                .ConfigureHttpClient((sp, client) => client.BaseAddress = new Uri(sp.GetRequiredService<IConfiguration>()["endpoints:api"]));


            await builder.Build().RunAsync();
        }
    }
}
