using Fluxor;
using Microsoft.AspNetCore.Components;
using Silvester.Pathfinder.Official.Documents.Models;
using Silvester.Pathfinder.Official.Web.Store.States.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Pages.Documents
{
    public abstract class BaseDocumentPage : ComponentBase
    {
        [Inject]
        public HttpClient HttpClient { get; set; } = default!;

        [Parameter]
        public string DocumentVersion { get; set; } = default!;
        
        public abstract string DocumentType { get; }

        protected Document? Document { get; set; }

        public JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true
        };

        protected async override Task OnInitializedAsync()
        {
            base.OnInitialized();
            HttpResponseMessage response = await HttpClient.GetAsync($"https://pf2e.io/api/documents/{DocumentType}/versions/{DocumentVersion}");
            Document = await JsonSerializer.DeserializeAsync<Document>(await response.Content.ReadAsStreamAsync(), JsonSerializerOptions);
        }
    }
}
