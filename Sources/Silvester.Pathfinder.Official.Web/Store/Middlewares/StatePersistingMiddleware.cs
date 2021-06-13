using Blazored.LocalStorage;
using Blazored.LocalStorage.StorageOptions;
using Fluxor;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silvester.Pathfinder.Official.Web.Store.Middlewares.Interfaces;
using Silvester.Pathfinder.Official.Web.Store.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Store.Middlewares
{
    public class StatePersistingMiddleware : Middleware
    {
        private IOptions<LocalStorageOptions> Options { get; }
        private ILocalStorageService LocalStorage { get; }
        private IStore Store { get; set; } = default!;
        
        public StatePersistingMiddleware(ILocalStorageService localStorage, IOptions<LocalStorageOptions> options)
        {
            LocalStorage = localStorage;
            Options = options;
        }

        public override Task InitializeAsync(IStore store)
        {
            Store = store;
            return Task.CompletedTask;
        }

        public override void AfterDispatch(object action)
        {
            if(action is IPersistedAction persistedAction)
            {
                _ = PersistStateAsync(persistedAction);
            }
        }

        public async Task PersistStateAsync(IPersistedAction action)
        {
            try
            {
                await LocalStorage.SetItemAsStringAsync(action.CreatePersistenceKey(), JsonSerializer.Serialize(action, action.GetType(), Options.Value.JsonSerializerOptions));
                Store.Dispatch(new SuccessfulAction());
            }
            catch (Exception exception)
            {
                Store.Dispatch(new FailedAction(exception.Message));
            }
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
