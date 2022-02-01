using CustomExceptions;

namespace BL;
public class RRBL : IBL
{
    private IRepo _dl;

    public RRBL(IRepo repo)
    {
        _dl = repo;
    }

    /// <summary>
    /// Gets all restaurants
    /// </summary>
    /// <returns>list of all restaurants</returns>
    public async Task<List<Restaurant>> GetAllRestaurantsAsync()
    {
        return await _dl.GetAllRestaurantsAsync();
    }

    /// <summary>
    /// Adds a new restaurant to the list
    /// </summary>
    /// <param name="restaurantToAdd">restaurant object to add</param>
    public Restaurant AddRestaurant(Restaurant restaurantToAdd)
    {
        if(!_dl.IsDuplicate(restaurantToAdd))
        {
            // return (Restaurant) _dl.Add(restaurantToAdd);
            return _dl.AddRestaurant(restaurantToAdd);
        }
        else throw new DuplicateRecordException("A restaurant with same name, city, and state already exists!");
    }

    public object Update(object entity)
    {
        return _dl.Update(entity);
    }

    public void Delete(object entity)
    {
        _dl.Delete(entity);
    }

    public Review GetReviewById(int reviewId)
    {
        return _dl.GetReviewById(reviewId);
    }

    /// <summary>
    /// Adds a new review to the restaurant that exists on that index
    /// </summary>
    /// <param name="restaurantId">index of the restaurant to leave a review for</param>
    /// <param name="reviewToAdd">a review object to be added to the restaurant</param>
    public Review AddReview(int restaurantId, Review reviewToAdd)
    {
        return (Review) _dl.Add(reviewToAdd);
    }

    public List<Restaurant> SearchRestaurants(string searchTerm)
    {
        return _dl.SearchRestaurants(searchTerm);
    }

    public async Task<Restaurant?> GetRestaurantByIdAsync(int restaurantId)
    {
        return await _dl.GetRestaurantByIdAsync(restaurantId);
    }

    public List<Review> GetReviewsByRestaurantId(int restaurantId)
    {
        return _dl.GetReviewsByRestaurantId(restaurantId);
    }
}
