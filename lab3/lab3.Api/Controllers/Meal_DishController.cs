using lab3.Repository.Domain;
using lab3.Services.SMeal_Dish;
using Microsoft.AspNetCore.Mvc;

namespace lab3.Api.Controller
{
    [Route("api/meal_dish")]
    public class Meal_DishController : ControllerBase
    {
        private readonly IMeal_DishService _meal_dishService;
        public Meal_DishController(IMeal_DishService meal_dishService)
        {
            _meal_dishService = meal_dishService;
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var meal_dish = _meal_dishService.GetById(id);
            if (meal_dish == null)
                return NotFound();
            return Ok(meal_dish);
        }
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var meal_dishs = _meal_dishService.GetAll();
            return Ok(meal_dishs);
        }
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] Meal_Dish model)
        {
            _meal_dishService.Insert(model);

            return Ok();
        }
        [HttpPut]
        [Route("")]
        public IActionResult Put([FromBody] Meal_Dish model)
        {
            _meal_dishService.Update(model);
            return Ok();
        }
        [HttpDelete]
        [Route("")]
        public IActionResult Delete([FromBody] Meal_Dish model)
        {
            _meal_dishService.Delete(model);
            return Ok();
        }
    }
}