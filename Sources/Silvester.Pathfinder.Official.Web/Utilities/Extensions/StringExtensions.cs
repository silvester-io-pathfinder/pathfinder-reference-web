using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Utilities.Extensions
{
    public static class StringExtensions
    {
        public static string Capitalize(this string self)
        {
            return self.Length == 0
                ? self
                : char.ToUpper(self.First()) + self.Substring(1);
        }
    }
}
