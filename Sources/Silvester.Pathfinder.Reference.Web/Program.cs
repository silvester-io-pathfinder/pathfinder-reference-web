using Blazor.Analytics;
using Blazored.LocalStorage;
using Fluxor;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using Silvester.Pathfinder.Reference.Web.Rest.DependencyInjection;
using Silvester.Pathfinder.Reference.Web.Services;
using Silvester.Pathfinder.Reference.Web.Services.Currencies;
using Silvester.Pathfinder.Reference.Web.Store.Middlewares;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web
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
            builder.Services.AddScoped<ISearchService, SearchService>();
            builder.Services.AddGoogleAnalytics("GTM-WH8BW86");
            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            });
            builder.Services.AddPathfinderReferenceApi();
            builder.Services.AddPathfinderReferenceRestClient((options, configuration) =>
            {
                options.Endpoint = new Uri(configuration.GetSection("endpoints:api")["endpoint"]);
                options.JsonSerializerOptions = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };
            });
            builder.Services
                .AddHttpClient(PathfinderReferenceApi.ClientName)
                .ConfigureHttpClient((sp, client) => client.BaseAddress = new Uri(sp.GetRequiredService<IConfiguration>()["endpoints:api:graphql"]));

            await builder.Build().RunAsync();
        }
    }
}