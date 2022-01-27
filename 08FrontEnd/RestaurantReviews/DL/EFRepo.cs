using Microsoft.EntityFrameworkCore;

namespace DL;

public class EFRepo : IRepo
{
    private RRDBContext _context;

    public EFRepo(RRDBContext context)
    {
        _context = context;
    }
    public Restaurant AddRestaurant(Restaurant restaurantToAdd)
    {
        _context.Add(restaurantToAdd);
        _context.SaveChanges();

        return restaurantToAdd;
    }

    // public void AddReview(int restaurantId, Review reviewToAdd)
    // {
    //     _context.Add(reviewToAdd);
    //     _context.SaveChanges();
    // }

    public object Add(object entity)
    {
        _context.Add(entity);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return entity;
    }

    public object Update(object entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        // _context.Update(entity);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return entity;
    }

    public void Delete(object entity){
        _context.Remove(entity);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public Review GetReviewById(int reviewId)
    {
        List<Review> review = _context.Reviews.Where(r => r.Id == reviewId).ToList();

        return review[0];

        // return _context.Reviews.FirstOrDefault(r => r.Id == reviewId);
    }

    public List<Restaurant> GetAllRestaurants()
    {
        // throw new NotImplementedException();
        // List<Restaurant> allResto = _context.Restaurants.Select(r => r).ToList();
        // return allResto;
        return _context.Restaurants.Select(r => r).ToList();
    }

    public async Task<List<Restaurant>> GetAllRestaurantsAsync()
    {
        return await _context.Restaurants
        .Include(r => r.Reviews)
        .AsNoTracking()
        .Select(r=>r)
        .ToListAsync();

        // _context.StoreFronts
        // .Include(s => s.Inventories)
        // .ThenInclude(i => i.Item)
        // .Select(s => s)
        // .ToList();
    }

    public async Task<Restaurant?> GetRestaurantByIdAsync(int restaurantId)
    {
        return await _context.Restaurants
        .Include("Reviews")
        .FirstOrDefaultAsync(r => r.Id == restaurantId);
    }

    public List<Review> GetReviewsByRestaurantId(int restaurantId)
    {
        return _context.Reviews.Where(r => r.RestaurantId == restaurantId).ToList();
    }

    public bool IsDuplicate(Restaurant restaurant)
    {
        /*
            In order to check for duplicate,
            I'm going to query for the first record that matches the name, city, and state of the restaurant we've been given
        */

        Restaurant? dupe = _context.Restaurants.FirstOrDefault(r => r.Name == restaurant.Name && r.City == restaurant.City && r.State == restaurant.State);

        return dupe != null;
        /*
            if(dupe == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        */
    }

    public List<Restaurant> SearchRestaurants(string searchTerm)
    {
        return _context.Restaurants.Where(x => x.Name.ToLower().Contains(searchTerm.ToLower()) ||
        x.State.ToLower().Contains(searchTerm.ToLower()) ||
        x.City.ToLower().Contains(searchTerm.ToLower()))
        .ToList();
    }
}