using Microsoft.Data.SqlClient;
//To get the above namespace working, run
//dotnet add package Microsoft.Data.Sqlclient
using System.Data;
//Include this namespace to be able to use DataSet
namespace DL;

public class DBRepo : IRepo
{
    private string _connectionString;
    public DBRepo(string connectionString) {
        _connectionString = connectionString;
    }

    /*
        We'll be using ADO.NET to connect our app to DB
        ADO.NET is collection of classes that allows us to work with
        various data sources in uniform fashion (SQL, OLE DB, XML, etc)
        4 Parts:
        1. Establish Connection
        2. Write the query you want to run
        3. Run it
        4. Process the data you get from it to C# object that rest of your app can consume
    */

    //ADO.NET: Disconnected Architecture saves data in memory
    //in DataSet, that persists outside of connection using DataAdapters
    //Data Adapters also manage connection for us
    //So we don't need to connect/disconnect manually
    //This is useful if you want to do more complex data manipulation
    //And C,U,D operation (Create, Update, Delete)
    //In order to work with data adapters,
    //We first give select statement to data adapter when we first set it up to get the table information and initial dataset
    //And then we do futher op on those dataset
    //and call Update method on the adapter.
    public void AddRestaurant(Restaurant restaurantToAdd)
    {
        DataSet restoSet = new DataSet();
        string selectCmd = "SELECT * FROM Restaurant WHERE Id = -1";
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            using(SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCmd, connection))
            {
                //DataSet is essentially just a container that holds data in memory
                //it holds one or more DataTables

                //We can fill that DataSet using SqlDataAdapter.Fill method
                dataAdapter.Fill(restoSet, "Restaurant");

                DataTable restoTable = restoSet.Tables["Restaurant"];
                
                //If you want to get the information on Data you queried when you called Fill method, we can iterate through DataTable.Rows property (has DataRow collection)
                //If you want info about the column (name, etc), iterate DataTable.Columns (that has DataColumn collection)
                //run debugger on them or docs/tutorials for more info
                // foreach(DataRow row in restoTable.Rows)
                // {
                //     Console.WriteLine(row["Id"]);
                // }

                //Generate a new row with the Restaurant Table Schema
                DataRow newRow = restoTable.NewRow();

                //Fill the new row with the new restaurant information
                newRow["Name"] = restaurantToAdd.Name;
                newRow["City"] = restaurantToAdd.City ?? "";
                newRow["State"] = restaurantToAdd.State ?? "";

                //add the new row to our restaurantTable Rows
                restoTable.Rows.Add(newRow);

                //We need to set which query to execute for changes
                //We need to set SqlDataAdapter.InsertCommand to let it know
                //How to insert the new records it sees in the restoTable
                string insertCmd = $"INSERT INTO Restaurant (Name, City, State) VALUES ('{restaurantToAdd.Name}', '{restaurantToAdd.City}', '{restaurantToAdd.State}')";

                //We have to tell the data adapter how to insert records (it's not magic)
                dataAdapter.InsertCommand = new SqlCommand(insertCmd, connection);
                //SqlDataAdapter.UpdateCommand (for your Put/Update operations)
                //SqlDataAdapter.DeleteCommand (for your Delete Operations)
                //Tell the dataAdapter to update the DB with changes
                dataAdapter.Update(restoTable);
            }
        }

    }

    public void AddReview(int restaurantIndex, Review reviewToAdd)
    {
        throw new NotImplementedException();
    }

    public List<Restaurant> GetAllRestaurants()
    {
        List<Restaurant> allRestaurants = new List<Restaurant>();
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            //Opening the connection to DB
            connection.Open();

            //assembling our query to query the db with
            string queryTxt = "SELECT * FROM Restaurant";
            //take the query text and connection we've built, and get ourselves
            //SqlCommand object that is capable of executing the command
            //on a particular SQL DB we specify.
            using(SqlCommand cmd = new SqlCommand(queryTxt, connection))
            {
                //Get the result of the command via SqlDataReader
                //SqlDataReader is part of what we call Connected Architecture
                //in ADO.NET
                //Data only exists while the connection is alive
                //And is not cached in memory
                //Efficient when working with large dataset because we are not storing all the data in our memory

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {   
                        Restaurant resto = new Restaurant();
                        resto.Id = reader.GetInt32(0);
                        resto.Name = reader.GetString(1);
                        resto.City = reader.GetString(2);
                        resto.State = reader.GetString(3);

                        allRestaurants.Add(resto);
                    }
                }
            }
            //closing the connection to DB
            connection.Close();
        }

        return allRestaurants;
    }
}