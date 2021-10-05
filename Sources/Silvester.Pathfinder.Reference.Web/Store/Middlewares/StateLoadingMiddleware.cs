using Blazored.LocalStorage;
using Blazored.LocalStorage.StorageOptions;
using Fluxor;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silvester.Pathfinder.Reference.Web.Store.Middlewares.Interfaces;
using Silvester.Pathfinder.Reference.Web.Store.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Store.Middlewares
{
    public class StateLoadingMiddleware : Middleware
    {
        private IOptions<LocalStorageOptions> Options { get; }
        private ILocalStorageService LocalStorage { get; }
        private IStore Store { get; set; } = default!;
        
        public StateLoadingMiddleware(ILocalStorageService localStorage, IOptions<LocalStorageOptions> options)
        {
            LocalStorage = localStorage;
            Options = options;
        }

        public override async Task InitializeAsync(IStore store)
        {
            Store = store;
            await LoadStateAsync();
        }

        private async Task LoadStateAsync()
        {
            await foreach (string key in GetKeysAsync(default))
            {
                try
                {
                    object action = await GetActionFromLocalStorageAsync(key, GetTypeFrom(key)!);
                    Store.Dispatch(action);
                    Store.Dispatch(new SuccessfulAction());
                }
                catch (Exception exception)
                {
                    Store.Dispatch(new FailedAction(exception.Message));
                    await LocalStorage.RemoveItemAsync(key);
                }
            }
        }

        private async Task<object> GetActionFromLocalStorageAsync(string key, Type type)
        {
            string actionString = await LocalStorage.GetItemAsStringAsync(key);
            return JsonSerializer.Deserialize(actionString, type, Options.Value.JsonSerializerOptions)!;
        }

        private async IAsyncEnumerable<string> GetKeysAsync([EnumeratorCancellation] CancellationToken cancellationToken)
        {
            for (int i = 0; i < await LocalStorage.LengthAsync(cancellationToken); i++)
            {
                string key = await LocalStorage.KeyAsync(i, cancellationToken);
                yield return key;
            }
        }

        private Type? GetTypeFrom(string key)
        {
            string[] split = key.Split("~");
            return Assembly.GetExecutingAssembly().GetType(split[0]);
        }

        public record SuccessfulAction;
        public record FailedAction : ILoggedAction
        {
            public LogLevel Level { get; }

            public string Message { get; }

            public FailedAction(string message)
            {
                Level = LogLevel.Error;
                Message = message;
            }
        }
    }
}
