using System;
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
            connectionString = $"server={server};port={port};database={database};user={username};password={password};";

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
                connection.Open(); // Open the connection

                MySqlCommand command = new MySqlCommand(query, connection);
                object result = command.ExecuteScalar();

                Console.WriteLine("Connection test successful.");
                Console.WriteLine("MySQL version: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close(); // Close the connection
            }
        }

        // Method to add a user to the database
        public void AddUser(string name, int id)
        {
            string query = "INSERT INTO users (name, id) VALUES (@name, @id)";

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", "Armin");
                command.Parameters.AddWithValue("@id", "56");

                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) inserted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        // Add more methods for executing queries, transactions, etc. as needed
    }
}
