using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTA.DataAccessLayer
{
    public interface IReadAllRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
