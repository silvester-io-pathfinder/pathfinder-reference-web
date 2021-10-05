using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Services
{
    public interface IClipboardService
    {
        ValueTask<string> ReadTextAsync();
        ValueTask WriteTextAsync(string text);
    }

    public sealed class ClipboardService : IClipboardService
    {
        private readonly IJSRuntime JsRuntime;

        public ClipboardService(IJSRuntime jsRuntime)
        {
            JsRuntime = jsRuntime;
        }

        public ValueTask<string> ReadTextAsync()
        {
            return JsRuntime.InvokeAsync<string>("navigator.clipboard.readText");
        }

        public ValueTask WriteTextAsync(string text)
        {
            return JsRuntime.InvokeVoidAsync("navigator.clipboard.writeText", text);
        }
    }
}
