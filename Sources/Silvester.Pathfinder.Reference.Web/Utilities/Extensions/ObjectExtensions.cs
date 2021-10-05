using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Utilities.Extensions
{
    public static class ObjectExtensions
    {
        public static Dictionary<string, object?> Splat(this object self)
        {
            Dictionary<string, object?> attributes = new();
            foreach(PropertyInfo property in self.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                attributes.Add(property.Name, property.GetValue(self));
            }
            return attributes;
        }
    }
}
