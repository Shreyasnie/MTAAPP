using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTA.DataAccessLayer.UnitOfWork
{
    public class UnitofWork : IUnitofwork
    {
        private MTADBContext dbContext = new MTADBContext();

        public IAreaRepository Area
        {
            get; private set;
        }
        public UnitofWork()
        {
            Area = new AreaRepository(dbContext);
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }

    public class MTADBContext : DbContext
    {
    }
}
