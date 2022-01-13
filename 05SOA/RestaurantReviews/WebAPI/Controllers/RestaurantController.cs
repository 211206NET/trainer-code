using Microsoft.AspNetCore.Mvc;
using Models;
using BL;
using CustomExceptions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private IBL _bl;
        public RestaurantController(IBL bl)
        {
            _bl = bl;
        }
        // GET: api/<RestaurantController>
        [HttpGet]
        public List<Restaurant> Get()
        {
            return _bl.GetAllRestaurants();
        }

        // GET api/<RestaurantController>/5
        [HttpGet("{id}")]
        public ActionResult<Restaurant> Get(int id)
        {
            Restaurant foundResto = _bl.GetRestaurantById(id);
            if(foundResto.Id != 0)
            {
                return Ok(foundResto);
            }
            else
            {
                return NoContent();
            }
        }

        // POST api/<RestaurantController>
        [HttpPost]
        public ActionResult Post([FromBody] Restaurant restoToAdd)
        {
            try
            {
                _bl.AddRestaurant(restoToAdd);
                return Created("Successfully added", restoToAdd);
            }
            catch (DuplicateRecordException ex)
            {
                return Conflict(ex.Message);
            }
        }

        // PUT api/<RestaurantController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RestaurantController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
