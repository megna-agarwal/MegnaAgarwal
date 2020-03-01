using lab3.Repository.Domain;

namespace lab3.Repository.RMeal
{
    public class MealRepository : GenericRepository<Meal>, IMealRepository
    {
        public MealRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}