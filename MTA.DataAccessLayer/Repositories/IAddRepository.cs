using System;
using System.Collections.Generic;
using System.Text;

namespace MTA.DataAccessLayer
{
    public interface IAddRepository <T> where T : class
    {
        bool Add(T entity);
    }
}
