using Blazored.LocalStorage;
using Blazored.LocalStorage.StorageOptions;
using Fluxor;
using Microsoft.Extensions.Options;
using Silvester.Pathfinder.Reference.Web.Store.Middlewares.Interfaces;
using Silvester.Pathfinder.Reference.Web.Store.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Store.Middlewares
{

    public class LoggingMiddleware : Middleware
    {
        public override void AfterDispatch(object action)
        {
            if(action is ILoggedAction loggedAction)
            {
                LogAction(loggedAction);
            }
        }

        public void LogAction(ILoggedAction action)
        {
            Console.WriteLine($"{action.Level}: {action.Message}");
        }
    }
}
