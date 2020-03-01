using lab3.Repository.Domain;
using lab3.Repository.RMeal;
namespace lab3.Services.SMeal
{
    public class MealService : GenericService<Meal>, IMealService
    {
        public MealService(IMealRepository mealRepository) :
        base(mealRepository)
        {

        }
    }
}