using Microsoft.AspNetCore.Http;
using MTA.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MTAService
{
    class AreaService : IAreaService
    {
        private readonly IAPIService apiService;
        private readonly IAreaBL areaBL;

        public AreaService(IAPIService apiService, IAreaBL areaBL)
        {
            this.apiService = apiService;
            this.areaBL = areaBL;
        }

        public bool GetAreaDetails()
        {
            string token = apiService.GetAccessToken();
            string uri = Environment.GetEnvironmentVariable("AreaDetailsURI");

            var areaDetails = apiService.GetDetails(token, uri).ToList();
            areaBL.UpdateAreas(null);

            return true;
        }
    }
}
