using MTA.DataAccessLayer.Model;
using MTA.DataAccessLayer.UnitOfWork;
using System;
using System.Collections.Generic;

namespace MTA.BusinessLayer
{
    public class AreaBL : IAreaBL
    {
        private readonly IUnitofwork unitofWork;

        public AreaBL(IUnitofwork unitofWork)
        {
            this.unitofWork = unitofWork;
        }

        public bool UpdateAreas(List<Area> Areas)
        {
            return unitofWork.Area.AddRange(Areas);
        }

        public void Dispose()
        {
            unitofWork.Dispose();
        }
    }
}
