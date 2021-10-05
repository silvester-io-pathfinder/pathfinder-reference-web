using Microsoft.Extensions.Options;
using Silvester.Pathfinder.Reference.Web.Rest.Exceptions;
using Silvester.Pathfinder.Reference.Web.Rest.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Rest
{
    public interface IPathfinderReferenceRestClient
    {
        IOptions<PathfinderReferenceRestClient.Options> ClientOptions { get; }

        Task<Document> GetLicenseAgreementAsync(int? version = null, CancellationToken cancellationToken = default);
        Task<Document> GetPrivacyPolicyAsync(int? version = null, CancellationToken cancellationToken = default);
    }

    public class PathfinderReferenceRestClient : IPathfinderReferenceRestClient
    {
        private HttpClient Client { get; }
        public IOptions<Options> ClientOptions { get; }

        public PathfinderReferenceRestClient(HttpClient client, IOptions<Options> clientOptions)
        {
            Client = client;
            ClientOptions = clientOptions;
        }

        public Task<Document> GetPrivacyPolicyAsync(int? version = null, CancellationToken cancellationToken = default)
        {
            string path = version.HasValue
                ? "documents/privacy-policies/versions/" + version.Value
                : "documents/privacy-policies/versions/latest";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, ClientOptions.Value.Endpoint + path);
            return GetAsync<Document>(request, cancellationToken);
        }

        public Task<Document> GetLicenseAgreementAsync(int? version = null, CancellationToken cancellationToken = default)
        {
            string path = version.HasValue
                ? "documents/license-agreements/versions/" + version.Value
                : "documents/license-agreements/versions/latest";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, ClientOptions.Value.Endpoint + path);
            return GetAsync<Document>(request, cancellationToken);
        }

        private async Task<TResource> GetAsync<TResource>(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpResponseMessage response = await Client.SendAsync(request);

            if (response.IsSuccessStatusCode == false)
            {
                throw new RestClientException(request, response);
            }

            return (await JsonSerializer.DeserializeAsync<TResource>(await response.Content.ReadAsStreamAsync(), ClientOptions.Value.JsonSerializerOptions, cancellationToken))!;
        }

        public class Options
        {
            [Required]
            public Uri Endpoint { get; set; } = default!;

            [Required]
            public JsonSerializerOptions JsonSerializerOptions { get; set; }

            public Options()
            {
                JsonSerializerOptions = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };
            }
        }
    }
}
