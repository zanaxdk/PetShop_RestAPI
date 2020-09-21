using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetShopApp.Core.AppService;
using PetShopApp.Core.Entities;
using PetShopApp.Infrastructure.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetShopApp.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetTypeController : ControllerBase
    {

        private ITypeService _typeService;
        public PetTypeController(ITypeService typeService)
        {
            _typeService = typeService;
        }

        // GET: api/<PetTypeController>
        [HttpGet]
        public ActionResult<IEnumerable<PetType>> Get([FromQuery] Filter filter)
        {
            try
            {
                return _typeService.GetTypes(filter);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        // GET api/<PetTypeController>/5
        [HttpGet("{id}")]
        public ActionResult<PetType> Get(int id)
        {
            try
            {
                return _typeService.GetTypes().Find(x => x.Id == id);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        // POST api/<PetTypeController>
        [HttpPost]
        public ActionResult<PetType> Post([FromBody] PetType value)
        {
            try
            {
                if (string.IsNullOrEmpty(value.name))
                {
                    return BadRequest("Name is required to create a new type!");
                }
                return StatusCode(201, _typeService.CreateType(value));
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        // PUT api/<PetTypeController>/5
        [HttpPut("{id}")]
        public ActionResult<PetType> Put(int id, [FromBody] PetType value)
        {
            try
            {
                if (string.IsNullOrEmpty(value.name))
                {
                    return BadRequest("Name is required to edit an type!");
                }
                else
                {
                    return StatusCode(202, _typeService.EditType(id, value));
                }
            }
            catch (Exception e)
            {
                return StatusCode(404, e);
            }
        }

        // DELETE api/<PetTypeController>/5
        [HttpDelete("{id}")]
        public ActionResult<Owner> Delete(int id)
        {
            try
            {
                return StatusCode(202, _typeService.Delete(id));
            }
            catch (Exception e)
            {
                return StatusCode(404, e);
            }
        }
    }
}
