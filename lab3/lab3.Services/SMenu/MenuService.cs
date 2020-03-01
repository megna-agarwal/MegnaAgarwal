using lab3.Repository.Domain;
using lab3.Repository.RMenu;
namespace lab3.Services.SMenu
{
    public class MenuService : GenericService<Menu>, IMenuService
    {
        public MenuService(IMenuRepository menuRepository) :
        base(menuRepository)
        {

        }
    }
}