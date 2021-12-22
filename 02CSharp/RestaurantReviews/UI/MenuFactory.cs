using DL;

namespace UI;
public static class MenuFactory
{
    public static IMenu GetMenu(string menuString)
    {
        menuString = menuString.ToLower();
        //This is full dep injection
        // new RestaurantMenu(new RRBL(new FileRepo())).Start();
        
        //Here, I instantiated an implementation of IRepo (FileRepo)
        IRepo repo = new FileRepo();
        //next, I instantiated RRBL (an implementation of IBL) and then injected IRepo implementation for IBL/RRBL
        IBL bl = new RRBL(repo);
        //Finally, I instantiate RestaurantMenu that needs an instance that implements Business Logic class
        switch (menuString)
        {
            case "main":
                return new MainMenu(bl);

            case "restaurant":
                return new RestaurantMenu(bl);
            
            case "review":
                return new ReviewMenu(bl);
            
            default:
                return new MainMenu(bl);
        }
    }
}