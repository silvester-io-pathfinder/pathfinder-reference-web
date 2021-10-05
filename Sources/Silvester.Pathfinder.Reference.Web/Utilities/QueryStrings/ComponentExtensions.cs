using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Utilities.QueryStrings
{
    public static class ComponentExtensions
    {
        public static void SetParametersFromQueryString<T>(this T component, NavigationManager navigationManager)
            where T : ComponentBase
        {
            if (Uri.TryCreate(navigationManager.Uri, UriKind.RelativeOrAbsolute, out Uri? uri) == false)
            {
                throw new InvalidOperationException("The current url is not a valid URI. Url: " + navigationManager.Uri);
            }

            Dictionary<string, StringValues> queryString = QueryHelpers.ParseQuery(uri.Query);

            foreach (PropertyInfo property in GetProperties<T>())
            {
                string? parameterName = GetQueryStringParameterName(property);
                if (parameterName == null)
                {
                    continue;
                }

                if (queryString.TryGetValue(parameterName, out StringValues value))
                {
                    object convertedValue = ConvertValue(value, property.PropertyType);
                    property.SetValue(component, convertedValue);
                }
            }
        }

        public static void UpdateQueryString<T>(this T component, NavigationManager navigationManager)
            where T : ComponentBase
        {
            if (Uri.TryCreate(navigationManager.Uri, UriKind.RelativeOrAbsolute, out Uri? uri) == false)
            {
                throw new InvalidOperationException("The current url is not a valid URI. Url: " + navigationManager.Uri);
            }

            Dictionary<string, StringValues> parameters = QueryHelpers.ParseQuery(uri.Query);
            foreach (PropertyInfo? property in GetProperties<T>())
            {
                string? parameterName = GetQueryStringParameterName(property);
                if (parameterName == null)
                {
                    continue;
                }

                object? value = property.GetValue(component);
                if (value is null)
                {
                    parameters.Remove(parameterName);
                }
                else
                {
                    string? convertedValue = ConvertToString(value);
                    parameters[parameterName] = convertedValue;
                }
            }

            string newUri = uri.GetComponents(UriComponents.Scheme | UriComponents.Host | UriComponents.Port | UriComponents.Path, UriFormat.UriEscaped);
            foreach (KeyValuePair<string, StringValues> parameter in parameters)
            {
                foreach (string? value in parameter.Value)
                {
                    newUri = QueryHelpers.AddQueryString(newUri, parameter.Key, value);
                }
            }

            navigationManager.NavigateTo(newUri);
        }

        private static object ConvertValue(StringValues value, Type type)
        {
            return Convert.ChangeType(value[0], type, CultureInfo.InvariantCulture);
        }

        private static string? ConvertToString(object value)
        {
            return Convert.ToString(value, CultureInfo.InvariantCulture);
        }

        private static PropertyInfo[] GetProperties<T>()
        {
            return typeof(T).GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        }

        private static string? GetQueryStringParameterName(PropertyInfo property)
        {
            QueryStringParameterAttribute? attribute = property.GetCustomAttribute<QueryStringParameterAttribute>();
            if (attribute == null)
            {
                return null;
            }

            return attribute.Name ?? property.Name;
        }
    }
}
