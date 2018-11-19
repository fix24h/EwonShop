using System;

namespace EwonShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        EwonShopDbContext Init();
    }
}