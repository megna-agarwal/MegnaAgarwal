using lab3.Repository.Domain;

namespace lab3.Repository.RMenu
{
    public class MenuRepository : GenericRepository<Menu>, IMenuRepository
    {
        public MenuRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}