using System;
using System.Collections.Generic;
using System.Text;

namespace MTA.DataAccessLayer.UnitOfWork
{
    public interface IUnitofwork : IDisposable
    {
        IAreaRepository Area { get; }
    }
}
