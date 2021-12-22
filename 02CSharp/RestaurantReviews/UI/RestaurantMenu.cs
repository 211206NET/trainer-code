using DL;

namespace UI;

public class RestaurantMenu : IMenu
{
    private IBL _bl;

    public RestaurantMenu(IBL bl) 
    {
        //example of dependency injection
        _bl = bl;
    }
    public void Start()
    {
        bool exit = false;
        while(!exit)
        {
            Console.WriteLine("This is Restaurant Menu");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[1] Create a new restaurant");
            Console.WriteLine("[2] View All Restaurants");
            Console.WriteLine("[x] Go Back to Main Menu");

            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    Console.WriteLine("Create a new restaurant:");
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("City: ");
                    string city = Console.ReadLine();
                    Console.WriteLine("State: ");
                    string state = Console.ReadLine();

                    //Initializing the class using empty constructor
                    // Restaurant newRestaurant = new Restaurant();
                    // newRestaurant.Name = name;
                    // newRestaurant.City = city;
                    // newRestaurant.State = state;

                    //another way to initialize a class
                    //using object initializer
                    Restaurant newRestaurant = new Restaurant {
                        Name = name,
                        City = city,
                        State = state
                    };

                    _bl.AddRestaurant(newRestaurant);
                break;

                case "2":
                    List<Restaurant> allRestaurants = _bl.GetAllRestaurants();
                    
                    //there is no restaurants stored anywhere
                    if(allRestaurants.Count == 0)
                    {
                        Console.WriteLine("No restaurants found :/");
                    }
                    else
                    {
                        Console.WriteLine("Here are all your restaurants!");
                        foreach(Restaurant resto in allRestaurants)
                        {
                            Console.WriteLine(resto.ToString());

                            if(resto.Reviews != null && resto.Reviews.Count > 0)
                            {
                                Console.WriteLine("======Reviews======");
                                foreach(Review review in resto.Reviews)
                                {
                                    Console.WriteLine(review.ToString());
                                }
                            }
                            else
                            {
                                Console.WriteLine("No Reviews :'(");
                            }
                        }
                    }
                break;

                case "x":
                    exit = true;
                break;
                default:
                    Console.WriteLine("I'm not sure what that was");
                break;
            }       

        }
    }
}