using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using lab3.Repository.RCustomer;
using lab3.Repository.RMeal;
using lab3.Repository.RMenu;
using lab3.Repository.RStaff;
using lab3.Repository.RMeal_Dish;
using lab3.Repository.RMenu_Item;
using lab3.Repository.RRef_Staff_Role;


namespace lab3.Repository
{
    public static class RepositoryModule
    {
        public static void Register(IServiceCollection services, string connection,
        string migrationsAssembly)
        {

            services.AddDbContext<RestaurantContext>(options =>

            options.UseSqlServer(connection, builder =>
            builder.MigrationsAssembly(migrationsAssembly)));

            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IMealRepository, MealRepository>();
            services.AddTransient<IMenuRepository, MenuRepository>();
            services.AddTransient<IStaffRepository, StaffRepository>();
            services.AddTransient<IMeal_DishRepository, Meal_DishRepository>();
            services.AddTransient<IMenu_ItemRepository, Menu_ItemRepository>();
            services.AddTransient<IRef_Staff_RoleRepository, Ref_Staff_RoleRepository>();

        }
    }
}