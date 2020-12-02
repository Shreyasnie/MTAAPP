using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MTA.DataAccessLayer
{
    public interface IReadRepository<T> where T : class
    {
        T Get(Expression<Func<T, bool>> expressionToRead);
    }
}
