using Microsoft.AspNetCore.Mvc;
using Models;
using BL;
using CustomExceptions;
using Microsoft.Extensions.Caching.Memory;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private IBL _bl;
        private IMemoryCache _memoryCache;
        public RestaurantController(IBL bl, IMemoryCache memoryCache)
        {
            _bl = bl;
            _memoryCache = memoryCache;
        }
        // GET: api/<RestaurantController>
        [HttpGet]
        public List<Restaurant> Get()
        {
            List<Restaurant> allResto;
            
            if(!_memoryCache.TryGetValue("restaurant", out allResto))
            {
                allResto = _bl.GetAllRestaurants();
                _memoryCache.Set("restaurant", allResto, new TimeSpan(0, 0, 30));
            }
            return allResto;
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

        [HttpGet("search/{term}")]
        public List<Restaurant> Search(string term)
        {
            return _bl.SearchRestaurants(term);
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
