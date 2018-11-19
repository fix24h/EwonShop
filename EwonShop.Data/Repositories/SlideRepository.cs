using EwonShop.Data.Infrastructure;
using EwonShop.Model.Models;

namespace EwonShop.Data.Repositories
{
    public interface ISlideRepository
    {
    }

    public class SlideRepository : RepositoryBase<Slide>, IPostRepository
    {
        public SlideRepository(IDbFactory iDbFactory) : base(iDbFactory)
        {
        }
    }
}