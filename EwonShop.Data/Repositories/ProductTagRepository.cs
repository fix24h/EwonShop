using EwonShop.Data.Infrastructure;
using EwonShop.Model.Models;

namespace EwonShop.Data.Repositories
{
    public interface IProductTagRepository
    {
    }

    public class ProductTagRepository : RepositoryBase<ProductTag>, IPostRepository
    {
        public ProductTagRepository(IDbFactory iDbFactory) : base(iDbFactory)
        {
        }
    }
}