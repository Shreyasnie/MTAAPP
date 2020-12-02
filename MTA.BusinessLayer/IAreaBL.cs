using MTA.DataAccessLayer.Model;
using System;
using System.Collections.Generic;

namespace MTA.BusinessLayer
{
    public interface IAreaBL : IDisposable
    {
        bool UpdateAreas(List<Area> Areas);
    }
}