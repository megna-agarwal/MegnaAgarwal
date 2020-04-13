using lab3.Repository.Domain;
using lab3.Services.SRef_Staff_Role;
using Microsoft.AspNetCore.Mvc;

namespace lab3.Api.Controller
{
    [Route("api/ref_staff_role")]
    public class Ref_Staff_RoleController : ControllerBase
    {
        private readonly IRef_Staff_RoleService _ref_staff_roleService;
        public Ref_Staff_RoleController(IRef_Staff_RoleService ref_staff_roleService)
        {
            _ref_staff_roleService = ref_staff_roleService;
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var ref_staff_role = _ref_staff_roleService.GetById(id);
            if (ref_staff_role == null)
                return NotFound();
            return Ok(ref_staff_role);
        }
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var ref_staff_roles = _ref_staff_roleService.GetAll();
            return Ok(ref_staff_roles);
        }
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] Ref_Staff_Role model)
        {
            _ref_staff_roleService.Insert(model);

            return Ok();
        }
        [HttpPut]
        [Route("")]
        public IActionResult Put([FromBody] Ref_Staff_Role model)
        {
            _ref_staff_roleService.Update(model);
            return Ok();
        }
        [HttpDelete]
        [Route("")]
        public IActionResult Delete([FromBody] Ref_Staff_Role model)
        {
            _ref_staff_roleService.Delete(model);
            return Ok();
        }
    }
}