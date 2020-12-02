using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MTAService
{
    class APIService : IAPIService
    {
        static HttpClient httpClient = new HttpClient();
        public IEnumerable<string> GetDetails(string token, string uri)
        {
            // call api using http client
            return null;
        }

        public string GetAccessToken()
        {
            return string.Empty;
        }
    }
}
