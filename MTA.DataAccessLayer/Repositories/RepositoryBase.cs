using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTA.DataAccessLayer
{
    abstract class RepositoryBase
    {
        private readonly DbContext dbContext;

        protected RepositoryBase(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        protected bool SaveChanges()
        {
            dbContext.SaveChanges();
            return true;
        }
    }
}
