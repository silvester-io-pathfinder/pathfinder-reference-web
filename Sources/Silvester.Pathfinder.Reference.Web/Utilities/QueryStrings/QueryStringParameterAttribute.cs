using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Utilities.QueryStrings
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class QueryStringParameterAttribute : Attribute
    {
        public string? Name { get; }

        public QueryStringParameterAttribute()
        {

        }

        public QueryStringParameterAttribute(string name)
        {
            Name = name;
        }
    }
}
