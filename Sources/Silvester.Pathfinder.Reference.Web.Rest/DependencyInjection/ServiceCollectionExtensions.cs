using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
                .AddTransient<IPathfinderReferenceRestClient, PathfinderReferenceRestClient>();

            return services;
        }
    }
}
