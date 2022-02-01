namespace BL;

public interface IBL
{
    List<Restaurant> SearchRestaurants(string searchString);


    Task<List<Restaurant>> GetAllRestaurantsAsync();

    object Update(object entity);

    void Delete(object entity);

    Review GetReviewById(int reviewId);

    Restaurant AddRestaurant(Restaurant restaurantToAdd);

    Review AddReview(int restaurantId, Review reviewToAdd);

    Task<Restaurant?> GetRestaurantByIdAsync (int restaurantId);

    public List<Review> GetReviewsByRestaurantId(int restaurantId);

}