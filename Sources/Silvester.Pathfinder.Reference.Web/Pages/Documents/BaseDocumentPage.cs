using Fluxor;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using Silvester.Pathfinder.Reference.Documents.Models;
using Silvester.Pathfinder.Reference.Web.Rest;
using Silvester.Pathfinder.Reference.Web.Store.States.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Pages.Documents
{
    public abstract class BaseDocumentPage : ComponentBase
    {
        [Inject]
        public IPathfinderReferenceRestClient HttpClient { get; set; } = default!;

        [Parameter]
        public string DocumentVersion { get; set; } = default!;
        
        public abstract string DocumentType { get; }

        protected Document? Document { get; set; }

        protected async override Task OnInitializedAsync()
        {
            base.OnInitialized();
            Document = await HttpClient.GetDocumentAsync(DocumentType, DocumentVersion); 
        }
    }
}
