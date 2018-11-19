using EwonShop.Data.Infrastructure;
using EwonShop.Model.Models;

namespace EwonShop.Data.Repositories
{
    public interface ITagRepository
    {
    }

    public class TagRepository : RepositoryBase<Tag>, IPostRepository
    {
        public TagRepository(IDbFactory iDbFactory) : base(iDbFactory)
        {
        }
    }
}