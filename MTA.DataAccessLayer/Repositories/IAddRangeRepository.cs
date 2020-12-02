using System;
using System.Collections.Generic;
using System.Text;

namespace MTA.DataAccessLayer
{
    public interface IAddRangeRepository <T> where T : class
    {
        bool AddRange(IEnumerable<T> entity);
    }
}
