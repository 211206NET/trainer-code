using Models;
using DL;

namespace BL;
public class RRBL
{
    /// <summary>
    /// Gets all restaurants
    /// </summary>
    /// <returns>list of all restaurants</returns>
    public List<Restaurant> GetAllRestaurants()
    {
        return StaticStorage.GetAllRestaurants();
    }

    /// <summary>
    /// Adds a new restaurant to the list
    /// </summary>
    /// <param name="restaurantToAdd">restaurant object to add</param>
    public void AddRestaurant(Restaurant restaurantToAdd)
    {
        StaticStorage.AddRestaurant(restaurantToAdd);
    }

    /// <summary>
    /// Adds a new review to the restaurant that exists on that index
    /// </summary>
    /// <param name="restaurantIndex">index of the restaurant to leave a review for</param>
    /// <param name="reviewToAdd">a review object to be added to the restaurant</param>
    public void AddReview(int restaurantIndex, Review reviewToAdd)
    {
        StaticStorage.AddReview(restaurantIndex, reviewToAdd);
    }
}
