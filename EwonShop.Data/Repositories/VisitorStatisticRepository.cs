using EwonShop.Data.Infrastructure;
using EwonShop.Model.Models;

namespace EwonShop.Data.Repositories
{
    public interface IVisitorStatisticRepository : IRepository<VisitorStatistic>
    {
    }

    public class VisitorStatisticRepository : RepositoryBase<VisitorStatistic>, IPostRepository
    {
        public VisitorStatisticRepository(IDbFactory iDbFactory) : base(iDbFactory)
        {
        }
    }
}