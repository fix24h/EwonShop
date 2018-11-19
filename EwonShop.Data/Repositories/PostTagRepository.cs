using EwonShop.Data.Infrastructure;

namespace EwonShop.Data.Repositories
{
    public interface IPostTagRepository
    {
    }

    public class PostTagRepository : RepositoryBase<PostTagRepository>, IPostRepository
    {
        public PostTagRepository(IDbFactory iDbFactory) : base(iDbFactory)
        {
        }
    }
}