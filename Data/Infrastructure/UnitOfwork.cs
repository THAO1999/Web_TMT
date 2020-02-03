using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
  public  class UnitOfwork:IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private TeduShopDbContext dbContext;
        public UnitOfwork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public TeduShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init());
            }
        }
        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
