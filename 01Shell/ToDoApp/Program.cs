using ToDo;

Console.WriteLine("Welcome to ToDo List");
Console.WriteLine("What would you like to do today?");
Console.WriteLine("1. Create a new todo item");
Console.WriteLine("2. View my list");
Console.WriteLine("3. Complete an item");

//instantiating an instance of our custom class
ToDoItem item = new ToDoItem();
//assigning values to the particular instance
item.IsDone = false;
item.Note = "Drink Coffee";

//Here, we're using the class' methods
Console.WriteLine(item.Print());

item.CompleteItem();

Console.WriteLine(item.Print());