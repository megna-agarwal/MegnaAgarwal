using lab3.Repository.Domain;
using lab3.Repository.RMenu_Item;
namespace lab3.Services.SMenu_Item
{
    public class Menu_ItemService : GenericService<Menu_Item>, IMenu_ItemService
    {
        public Menu_ItemService(IMenu_ItemRepository menu_ItemRepository) :
        base(menu_ItemRepository)
        {

        }
    }
}