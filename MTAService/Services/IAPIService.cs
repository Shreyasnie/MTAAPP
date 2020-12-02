using System.Collections.Generic;

namespace MTAService
{
    interface IAPIService
    {
        IEnumerable<string> GetDetails(string token, string uri);

        public string GetAccessToken();
    }
}