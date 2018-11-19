using EwonShop.Data.Infrastructure;
using EwonShop.Model.Models;

namespace EwonShop.Data.Repositories
{
    public interface ISystemConfigRepository
    {
    }

    public class SystemConfigRepository : RepositoryBase<SystemConfig>, IPostRepository
    {
        public SystemConfigRepository(IDbFactory iDbFactory) : base(iDbFactory)
        {
        }
    }
}