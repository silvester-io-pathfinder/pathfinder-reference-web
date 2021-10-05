using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Rest.Exceptions
{
    public class RestClientException : Exception
    {
        public HttpRequestMessage Request { get; }
        public HttpResponseMessage Response { get; }

        public RestClientException(HttpRequestMessage request, HttpResponseMessage response)
            : base(CreateMessage(request, response))
        {
            Request = request;
            Response = response;
        }

        private static string CreateMessage(HttpRequestMessage request, HttpResponseMessage response)
        {
            return $"Status code '{response?.StatusCode}' was encountered when calling '{request.RequestUri}'.";
        }
    }
}
