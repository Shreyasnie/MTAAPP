using Microsoft.EntityFrameworkCore;
using MTA.DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MTA.DataAccessLayer
{
    class AreaRepository : RepositoryBase,IAreaRepository
    {
        private readonly DbContext dbContext;

        public AreaRepository(DbContext dbContext) : base (dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool Add(Area entity)
        {
            dbContext.Add(entity);

            return true;
        }

        public bool AddRange(IEnumerable<Area> entity)
        {
            dbContext.AddRange(entity);
            return true;
        }

        public Area Get(Expression<Func<Area, bool>> expressionToRead)
        {
            try
            {
                return dbContext.Set<Area>().FirstOrDefault(expressionToRead);
            }
            catch (Exception ex)
            {
                //logging.Log.Instance.Error(ex);
            }

            return null;
        }

        public IEnumerable<Area> GetAll()
        {
            return dbContext.Set<Area>().OrderBy(x => x.Id);
        }
    }
}
