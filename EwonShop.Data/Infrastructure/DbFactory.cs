using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EwonShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private EwonShopDbContext dbContext;

        public EwonShopDbContext Init()
        {
            return dbContext ?? (dbContext = new EwonShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
