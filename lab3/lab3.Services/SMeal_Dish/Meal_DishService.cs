using lab3.Repository.Domain;
using lab3.Repository.RMeal_Dish;
namespace lab3.Services.SMeal_Dish
{
    public class Meal_DishService : GenericService<Meal_Dish>, IMeal_DishService
    {
        public Meal_DishService(IMeal_DishRepository meal_DishRepository) :
        base(meal_DishRepository)
        {

        }
    }
}