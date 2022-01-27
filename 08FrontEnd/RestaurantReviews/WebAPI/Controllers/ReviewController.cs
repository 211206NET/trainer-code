using Microsoft.AspNetCore.Mvc;
using BL;
using Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private IBL _bl;
        public ReviewController(IBL bl)
        {
            _bl = bl;
        }
        //// GET: api/<ReviewController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        /// <summary>
        /// Gets all reviews by restaurant Id
        /// </summary>
        /// <param name="restaurantId">int restaurant id</param>
        /// <returns></returns>
        // GET api/<ReviewController>/5
        [HttpGet("{restaurantId}")]
        public List<Review> Get(int restaurantId)
        {
            return _bl.GetReviewsByRestaurantId(restaurantId);
        }

        // POST api/<ReviewController>
        [HttpPost]
        public Review Post([FromBody] Review reviewToAdd)
        {
            return _bl.AddReview(reviewToAdd.RestaurantId, reviewToAdd);
        }

        // PUT api/<ReviewController>/5
        [HttpPut("{id}")]
        public Review Put(int id, [FromBody] Review reviewToUpdate)
        {
            return (Review) _bl.Update(reviewToUpdate);
        }

        // DELETE api/<ReviewController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Review reviewToDelete = _bl.GetReviewById(id);
            
            if (reviewToDelete != null)
            {
                _bl.Delete(reviewToDelete);
            }
        }
    }
}
