using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    // khoi tao doi tuong dbContext
    // thay vi new truc tiep thif bay gio new qua Db factory
    public class DbFactory : Disposable, IDbFactory
    {
        // khoi tao doi tuong dbContext 
        
        TeduShopDbContext dbContext;



        public TeduShopDbContext Init()
        {
            
            return dbContext ?? (dbContext = new TeduShopDbContext());

        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
