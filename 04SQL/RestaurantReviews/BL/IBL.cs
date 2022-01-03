namespace BL;

public interface IBL
{
    // Restaurant SearchRestaurant(string searchString);

    List<Restaurant> GetAllRestaurants();

    void AddRestaurant(Restaurant restaurantToAdd);

    void AddReview(int restaurantId, Review reviewToAdd);
}