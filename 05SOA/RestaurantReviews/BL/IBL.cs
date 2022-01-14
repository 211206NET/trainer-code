namespace BL;

public interface IBL
{
    List<Restaurant> SearchRestaurants(string searchString);


    Task<List<Restaurant>> GetAllRestaurantsAsync();


    void AddRestaurant(Restaurant restaurantToAdd);

    void AddReview(int restaurantId, Review reviewToAdd);

    Task<Restaurant> GetRestaurantByIdAsync (int restaurantId);

    public List<Review> GetReviewsByRestaurantId(int restaurantId);

}