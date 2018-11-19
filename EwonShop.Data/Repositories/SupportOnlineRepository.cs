using EwonShop.Data.Infrastructure;
using EwonShop.Model.Models;

namespace EwonShop.Data.Repositories
{
    public interface ISupportOnlineRepository
    {
    }

    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, IPostRepository
    {
        public SupportOnlineRepository(IDbFactory iDbFactory) : base(iDbFactory)
        {
        }
    }
}