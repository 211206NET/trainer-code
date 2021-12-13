using RestaurantReviews;

//initialize my list of restaurants
List<Restaurant> allRestaurants = new List<Restaurant>();
bool exit = false;
Console.WriteLine("Welcome to Restaurant Reviews!");

while(!exit)
{
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

    allRestaurants.Add(newRestaurant);

    Console.WriteLine("Here are all your restaurants!");
    foreach(Restaurant resto in allRestaurants)
    {
        Console.WriteLine($"Name: {resto.Name} \nCity: {resto.City} \nState: {resto.State}");
    }

    Console.WriteLine("Would you like to add another one? [y/n]");
    string input = Console.ReadLine();
    if(input == "n")
    {
        exit = true;
    }
}