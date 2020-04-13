using lab3.Repository.Domain;
using lab3.Services.SMenu_Item;
using Microsoft.AspNetCore.Mvc;

namespace lab3.Api.Controller
{
    [Route("api/menu_item")]
    public class Menu_ItemController : ControllerBase
    {
        private readonly IMenu_ItemService _menu_itemService;
        public Menu_ItemController(IMenu_ItemService menu_itemService)
        {
            _menu_itemService = menu_itemService;
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var menu_item = _menu_itemService.GetById(id);
            if (menu_item == null)
                return NotFound();
            return Ok(menu_item);
        }
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var menu_items = _menu_itemService.GetAll();
            return Ok(menu_items);
        }
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] Menu_Item model)
        {
            _menu_itemService.Insert(model);

            return Ok();
        }
        [HttpPut]
        [Route("")]
        public IActionResult Put([FromBody] Menu_Item model)
        {
            _menu_itemService.Update(model);
            return Ok();
        }
        [HttpDelete]
        [Route("")]
        public IActionResult Delete([FromBody] Menu_Item model)
        {
            _menu_itemService.Delete(model);
            return Ok();
        }
    }
}