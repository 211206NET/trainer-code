using Microsoft.EntityFrameworkCore;

public class RRDBContext : DbContext
{
    // Empty constructor for RRDBContext, that calls the empty constructor for DbContext
    public RRDBContext() : base() { }

    //if I need to pass in the options, I'm also just going to call my parent's constructor that takes in options via constructor chaining
    public RRDBContext(DbContextOptions options) : base(options) { }

    public DbSet<Restaurant> Restaurants { get; set; }

    public DbSet<Review> Reviews { get; set; }

    //if you want to manually modify certain columns, properties...
    //map them here
    /*protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Restaurant>()
        .Property(restaurant => restaurant.Id)
        .ValueGeneratedOnAdd();
        modelBuilder.Entity<Review>()
        .Property(review => review.Id)
        .ValueGeneratedOnAdd();
    }*/
}