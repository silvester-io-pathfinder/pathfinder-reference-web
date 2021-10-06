using Microsoft.Extensions.Options;
using Silvester.Pathfinder.Reference.Documents.Models;
using Silvester.Pathfinder.Reference.Web.Rest.Exceptions;
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

        Task<Document> GetDocumentAsync(string documentType, string documentVersion, CancellationToken cancellationToken = default);
        Task<Document> GetLicenseAgreementAsync(int? version = null, CancellationToken cancellationToken = default);
        Task<Document> GetPrivacyPolicyAsync(int? version = null, CancellationToken cancellationToken = default);
    }

    public class PathfinderReferenceRestClient : IPathfinderReferenceRestClient
    {
        private HttpClient Client { get; }
        public IOptions<Options> ClientOptions { get; }

        public PathfinderReferenceRestClient(IHttpClientFactory clientFactory, IOptions<Options> clientOptions)
        {
            Client = clientFactory.CreateClient(typeof(IPathfinderReferenceRestClient).Name);
            ClientOptions = clientOptions;
            
            Console.WriteLine("INJECTED: " + Client.BaseAddress.ToString());
        }

        public Task<Document> GetPrivacyPolicyAsync(int? version = null, CancellationToken cancellationToken = default)
        {
            string path = version.HasValue
                ? "documents/privacy-policies/versions/" + version.Value
                : "documents/privacy-policies/versions/latest";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, path);
            return GetAsync<Document>(request, cancellationToken);
        }

        public Task<Document> GetLicenseAgreementAsync(int? version = null, CancellationToken cancellationToken = default)
        {
            string path = version.HasValue
                ? "documents/license-agreements/versions/" + version.Value
                : "documents/license-agreements/versions/latest";
            
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, path);
            return GetAsync<Document>(request, cancellationToken);
        }

        public Task<Document> GetDocumentAsync(string documentType, string documentVersion, CancellationToken cancellationToken = default)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"documents/{documentType}/versions/{documentVersion}");
            return GetAsync<Document>(request, cancellationToken);
        }

        private async Task<TResource> GetAsync<TResource>(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Console.WriteLine("REQUEST URI: " + Client.BaseAddress + request.RequestUri.ToString());
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
