using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace FoodRecipeApp_24.Data
{
    public class Database
    {
        private string connectionString; // Connection string to your MySQL database
        private MySqlConnection connection; // MySQL connection object

        // Constructor to initialize the connection string
        public Database(string server, int port, string database, string username, string password)
        {
            // Construct the connection string
            connectionString = "server=127.0.0.1;port=3306;database=foodrecipeapp_24;user=root;password=;";

            // Initialize the connection object
            connection = new MySqlConnection(connectionString);
        }

        // Method to open the database connection
        public void OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Database connection opened successfully!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error opening database connection: {ex.Message}");
            }
        }

        // Method to close the database connection
        public void CloseConnection()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Database connection closed successfully!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error closing database connection: {ex.Message}");
            }
        }

        // Method to test the database connection
        public void TestConnection()
        {
            string query = "SELECT version()";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);
                    object result = command.ExecuteScalar();

                    Console.WriteLine("Connection test successful.");
                    Console.WriteLine("MySQL version: " + result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Add more methods for executing queries, transactions, etc. as needed
    }
}
