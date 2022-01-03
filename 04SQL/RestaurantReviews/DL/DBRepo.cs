using Microsoft.Data.SqlClient;
//To get the above namespace working, run
//dotnet add package Microsoft.Data.Sqlclient
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

    public void AddRestaurant(Restaurant restaurantToAdd)
    {
        throw new NotImplementedException();
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