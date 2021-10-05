using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Rest.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPathfinderOfficialRestClient(this IServiceCollection services, Action<PathfinderOfficialRestClient.Options, IConfiguration> configureAction)
        {
            services
                .AddOptions<PathfinderOfficialRestClient.Options>()
                .Configure(configureAction)
                .ValidateDataAnnotations();

            services
                .AddTransient<IPathfinderOfficialRestClient, PathfinderOfficialRestClient>();

            return services;
        }
    }
}
