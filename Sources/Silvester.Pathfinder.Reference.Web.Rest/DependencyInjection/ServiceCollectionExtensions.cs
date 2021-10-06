using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Rest.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPathfinderReferenceRestClient(this IServiceCollection services, Action<PathfinderReferenceRestClient.Options, IConfiguration> configureAction)
        {
            services
                .AddOptions<PathfinderReferenceRestClient.Options>()
                .Configure(configureAction)
                .ValidateDataAnnotations();

            services
                .AddHttpClient(typeof(IPathfinderReferenceRestClient).Name, (sp, client) => 
                {
                    IOptions<PathfinderReferenceRestClient.Options> options = sp.GetRequiredService<IOptions<PathfinderReferenceRestClient.Options>>();
                    client.BaseAddress = options.Value.Endpoint;
                }) ;

            services
                .AddTransient<IPathfinderReferenceRestClient, PathfinderReferenceRestClient>();

            return services;
        }
    }
}
