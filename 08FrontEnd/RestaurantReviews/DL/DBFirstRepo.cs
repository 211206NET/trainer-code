using Entity = DL.Entities;
using Model = Models;
using Microsoft.EntityFrameworkCore;

namespace DL;

public class DBFirstRepo : IRepo
{
    private Entity.RestaurantDBContext _context;
    public DBFirstRepo(Entity.RestaurantDBContext context)
    {
        _context = context;
    }

    public object Add(object entity)
    {
        throw new NotImplementedException();
    }

    public Model.Restaurant AddRestaurant(Model.Restaurant resto)
    {
        Entity.Restaurant entityResto = _context.Add(new Entity.Restaurant{
            Id = resto.Id,
            Name = resto.Name,
            City = resto.City,
            State = resto.State
        }).Entity;
        _context.SaveChanges();
        _context.ChangeTracker.Clear();

        resto.Id = entityResto.Id;

        return resto;
    }

    public void Delete(object entity)
    {
        throw new NotImplementedException();
    }

    public List<Restaurant> GetAllRestaurants()
    {
        throw new NotImplementedException();
    }

    public async Task<List<Model.Restaurant>> GetAllRestaurantsAsync()
    {
        return await _context.Restaurants
        .Select(r => new Model.Restaurant{
            Id = r.Id,
            Name = r.Name,
            City = r.City ?? "",
            State = r.State ?? ""
        }).ToListAsync();
    }

    public Task<Restaurant?> GetRestaurantByIdAsync(int restaurantId)
    {
        throw new NotImplementedException();
    }

    public Review GetReviewById(int reviewId)
    {
        throw new NotImplementedException();
    }

    public List<Review> GetReviewsByRestaurantId(int restaurantId)
    {
        throw new NotImplementedException();
    }

    public bool IsDuplicate(Model.Restaurant restaurant)
    {
        Entity.Restaurant? dupe = _context.Restaurants.FirstOrDefault(r => r.Name == restaurant.Name && r.City == restaurant.City && r.State == restaurant.State);

        return dupe != null;
    }

    public List<Restaurant> SearchRestaurants(string searchTerm)
    {
        throw new NotImplementedException();
    }

    public object Update(object entity)
    {
        throw new NotImplementedException();
    }
}