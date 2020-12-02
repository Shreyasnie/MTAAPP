using MTA.DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTA.DataAccessLayer
{
    public interface IAreaRepository : IReadAllRepository<Area>,
        IReadRepository<Area>,IAddRepository<Area>,IAddRangeRepository<Area>
    {
    }
}
