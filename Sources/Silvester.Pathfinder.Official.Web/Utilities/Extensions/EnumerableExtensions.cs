using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Utilities.Extensions
{
    public static class EnumerableExtensions
    {
        public static string Join(this IEnumerable<string> self, string separators)
        {
            return string.Join(separators, self);
        }
    }
}
