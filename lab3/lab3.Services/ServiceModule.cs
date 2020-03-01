using Microsoft.Extensions.DependencyInjection;
using lab3.Services.SCustomer;
using lab3.Services.SMeal;
using lab3.Services.SMenu;
using lab3.Services.SStaff;
using lab3.Services.SMeal_Dish;
using lab3.Services.SMenu_Item;
using lab3.Services.SRef_Staff_Role;

namespace lab3.Services
{
    public static class ServicesModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IMealService, MealService>();
            services.AddTransient<IMenuService, MenuService>();
            services.AddTransient<IStaffService, StaffService>();
            services.AddTransient<IMeal_DishService, Meal_DishService>();
            services.AddTransient<IMenu_ItemService, Menu_ItemService>();
            services.AddTransient<IRef_Staff_RoleService, Ref_Staff_RoleService>();

        }
    }
}