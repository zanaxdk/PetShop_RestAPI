using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetShopApp.Core.AppService;
using PetShopApp.Core.AppService.Impl;
using PetShopApp.Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetShopApp.WebApp.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {

        private IOwnerService _ownerService;
        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        // GET: api/<OwnerController>
        [HttpGet]
        public ActionResult<IEnumerable<Owner>> Get()
        {
            try
            {
                return _ownerService.GetOwners();
            }
            catch (Exception e)
            { 
                return StatusCode(500, e);
            }
        }

        // GET api/<OwnerController>/5
        [HttpGet("{id}")]
        public ActionResult<Owner> Get(int id)
        {
            try
            {
                return _ownerService.GetOwners().Find(x => x.ID == id);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        // POST api/<OwnerController>
        [HttpPost]
        public ActionResult<Owner> Post([FromBody] Owner value)
        {
            try
            {
                if (string.IsNullOrEmpty(value.FName))
                {
                    return BadRequest("Name is required to create a new owner!");
                }
                return StatusCode(201, _ownerService.CreateOwner(value));
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        // PUT api/<OwnerController>/5
        [HttpPut("{id}")]
        public ActionResult<Owner> Put(int id, [FromBody] Owner value)
        {
            try
            {
                if (string.IsNullOrEmpty(value.FName))
                {
                    return BadRequest("Name is required to edit an owner!");
                }
                else
                {
                    return StatusCode(202, _ownerService.EditOwner(id, value));
                }
            }
            catch (Exception e)
            {
                return StatusCode(404, e);
            }
        }

        // DELETE api/<OwnerController>/5
        [HttpDelete("{id}")]
        public ActionResult<Owner> Delete(int id)
        {
            try
            {
                return StatusCode(202, _ownerService.Delete(id));
            }
            catch (Exception e)
            {
                return StatusCode(404, e);
            }
        }
    }
}
