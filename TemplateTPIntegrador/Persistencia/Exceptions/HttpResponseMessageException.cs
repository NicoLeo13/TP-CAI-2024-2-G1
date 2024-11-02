using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Exceptions
{
    public class HttpResponseMessageException : Exception
    {
        public HttpResponseMessage Response { get; }

        public HttpResponseMessageException(HttpResponseMessage response)
        {
            Response = response;
        }
    }
}
