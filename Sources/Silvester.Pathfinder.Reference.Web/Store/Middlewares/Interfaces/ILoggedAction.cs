using Microsoft.Extensions.Logging;

namespace Silvester.Pathfinder.Reference.Web.Store.Middlewares.Interfaces
{
    public interface ILoggedAction
    {
        LogLevel Level { get; }
        string Message { get; }
    }
}
