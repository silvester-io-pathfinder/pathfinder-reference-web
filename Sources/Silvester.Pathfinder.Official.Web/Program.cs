using Fluxor;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using Silvester.Pathfinder.Official.Web.Graphql;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using Silvester.Pathfinder.Official.Web.Pages.Overviews;
using Silvester.Pathfinder.Official.Web.Pages.Overviews.Feats;
using Silvester.Pathfinder.Official.Web.Pages.Overviews.Spells;
using Silvester.Pathfinder.Official.Web.Services;
using Silvester.Pathfinder.Official.Web.Shared.Tables;
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
            builder.Services.AddFluxor(options => options.ScanAssemblies(typeof(Program).Assembly));

            builder.Services.AddScoped<IClipboardService, ClipboardService>();
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
