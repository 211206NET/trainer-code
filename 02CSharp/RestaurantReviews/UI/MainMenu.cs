using DL;

namespace UI;
public class MainMenu {
    private IBL _bl;

    public MainMenu(IBL bl)
    {
        _bl = bl;
    }
    public void Start() {
        bool exit = false;
        Console.WriteLine("Welcome to Restaurant Reviews!");

        while(!exit)
        {
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("[1] Manage Restaurant");
            Console.WriteLine("[2] Leave a review");
            Console.WriteLine("[x] Exit");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //This is full dep injection
                    // new RestaurantMenu(new RRBL(new FileRepo())).Start();
                    
                    //Here, I instantiated an implementation of IRepo (FileRepo)
                    IRepo repo = new FileRepo();
                    //next, I instantiated RRBL (an implementation of IBL) and then injected IRepo implementation for IBL/RRBL
                    IBL bl = new RRBL(repo);
                    //Finally, I instantiate RestaurantMenu that needs an instance that implements Business Logic class
                    RestaurantMenu restaurantMenu = new RestaurantMenu(bl);

                    //Dep injection is done, everyone has all the things it needs to function, call the start method of the menu.
                    restaurantMenu.Start();
                break;
                case "2":
                    List<Restaurant> allRestaurants = _bl.GetAllRestaurants();
                    Console.WriteLine("Select a restaurant to leave reviews for");
                    for(int i = 0; i < allRestaurants.Count; i++)
                    {
                        Console.WriteLine($"[{i}] Name: {allRestaurants[i].Name} \nCity: {allRestaurants[i].City} \nState: {allRestaurants[i].State}");
                    }
                    int selection = Int32.Parse(Console.ReadLine());

                    //now I want to collect information about the review
                    Console.WriteLine("Give a rating: ");
                    int rating = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Leave a Review: ");
                    string note = Console.ReadLine();

                    Review newReview = new Review(rating, note);

                    _bl.AddReview(selection, newReview);
                    Console.WriteLine("Your review has been successfully added!");
                break;
                case "x":
                    exit = true;
                    Console.WriteLine("goodbye!");
                break;

            }
        }
    }
}
