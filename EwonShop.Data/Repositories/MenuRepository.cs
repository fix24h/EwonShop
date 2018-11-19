using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EwonShop.Data.Infrastructure;
using EwonShop.Model.Models;

namespace EwonShop.Data.Repositories
{
    public interface IMenuRepository{

    }
    public class MenuRepository : RepositoryBase<MenuGroup>, IMenuRepository
    {
        public MenuRepository(IDbFactory iDbFactory) : base(iDbFactory)
        {
        }
    }
}
