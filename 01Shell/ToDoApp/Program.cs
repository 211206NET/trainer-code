using ToDo;
using System.Collections.Generic;

bool exit = false;
//Instantiating our list of todoItems
List<ToDoItem> toDoList = new List<ToDoItem>();
do
{
    Console.WriteLine("Welcome to ToDo List");
    Console.WriteLine("What would you like to do today?");
    Console.WriteLine("1: Create a new todo item");
    Console.WriteLine("2: View my list");
    Console.WriteLine("3: Complete an item");
    Console.WriteLine("x: Exit");
    string input = Console.ReadLine();
    // //instantiating an instance of our custom class
    // ToDoItem item = new ToDoItem();
    // //assigning values to the particular instance
    // item.IsDone = false;
    // item.Note = "Drink Coffee";

    // //Here, we're using the class' methods
    // Console.WriteLine(item.Print());
    // item.CompleteItem();
    // Console.WriteLine(item.Print());

    switch(input)
    {
        case "1":
            Console.WriteLine("Enter details for the new todo item");
            Console.WriteLine("Item Note: ");
            //taking the user input and saving it as string var named newNote
            string newNote = Console.ReadLine();

            ToDoItem newItem = new ToDoItem();
            newItem.IsDone = false;
            newItem.Note = newNote;

            toDoList.Add(newItem);
            Console.WriteLine("You created the following item: ");
            Console.WriteLine(newItem.Print());
        break;
        case "2":
            //foreach loop loops through items in a collection
            foreach(ToDoItem item in toDoList)
            {
                Console.WriteLine(item.Print());
            }
        break;
        case "3":
            Console.WriteLine("Choose an item to complete");
            //First, we're iterating through the list to display each listitem
            //and its index (where they're located in the list)
            //This index for item does not change
            //so we can take advantage of that fact and 
            //precisely locate the item
            //Count is a property of generic collection List<T>
            //where it returns the number of current items in the list
            for(int i = 0; i < toDoList.Count; i++)
            {
                Console.WriteLine($"[{i}] {toDoList[i].Print()}");
                // Console.WriteLine("[{0}] {1}", i, toDoList[i].Print());
            }

            //Take in the user input and naively assume that users know what they are doing
            //and parse it to integer so we can access the item by its index
            int selection = int.Parse(Console.ReadLine());

            //We found the item that the user wanted to complete
            ToDoItem itemToComplete = toDoList[selection];

            //we called the complete item method that marks IsDone property to true
            itemToComplete.CompleteItem();

            //Confirmation message
            Console.WriteLine($"You completed {itemToComplete.Print()}");
        break;
        case "x":
            Console.WriteLine("Goodbye!");
            exit = true;
        break;
        default:
            Console.WriteLine("I'm not sure what that was");
        break;
    }
} while(!exit);