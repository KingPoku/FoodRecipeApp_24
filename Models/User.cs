using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FoodRecipeApp_24.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        private string _hashedPassword; // Store hashed password
        public string ProfilePictureUrl { get; set; }
        public List<string> FavoriteMeals { get; set; } // List of favorite meals

        // Constructor
        public User(int userId, string firstName, string lastName, string username, string email, string password)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Email = email;
            _hashedPassword = HashPassword(password); // Hash the provided password
        }

        // Method to hash password
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Method to verify password
        public bool VerifyPassword(string password)
        {
            string hashedInput = HashPassword(password);
            return hashedInput == _hashedPassword;
        }

        // Method to login
        public bool Login(string usernameOrEmail, string password)
        {
            // Check if username or email matches and password is correct
            if ((Username == usernameOrEmail || Email == usernameOrEmail) && VerifyPassword(password))
            {
                return true; // Successful login
            }
            return false; // Login failed
        }

        // Method to delete account
        public void DeleteAccount()
        {
            // Delete user account logic (e.g., database deletion)
        }

        // Method to upload a profile picture
        public void UploadProfilePicture(string imageUrl)
        {
            ProfilePictureUrl = imageUrl;
            // Additional logic (e.g., save image to storage)
        }

        // Method to change password
        public void ChangePassword(string newPassword)
        {
            _hashedPassword = HashPassword(newPassword);
            // Additional logic (e.g., update password in database)
        }

        // Method to leave a review
        public void LeaveReview(int recipeId, string review)
        {
            // Logic to leave a review for a specific recipe
        }

        // Method to add a favorite meal
        public void AddFavoriteMeal(string mealName)
        {
            FavoriteMeals ??= new List<string>(); // Initialize list if null
            FavoriteMeals.Add(mealName);
            // Additional logic (e.g., save favorite meal in database)
        }

        // Method to search for a recipe
        public List<string> SearchRecipe(string query)
        {
            // Logic to search for recipes based on the query
            return new List<string>(); // Placeholder return
        }

        // Method to make a meal plan
        public void MakeMealPlan(DateTime date, List<int> recipeIds)
        {
            // Logic to create a meal plan for a specific date with selected recipes
        }

        // Method to add items to shopping list or fridge inventory
        public void AddToInventory(string itemName, int quantity)
        {
            // Logic to add items to shopping list or fridge inventory
        }

        // Method to get recipes based on ingredients
        public List<string> GetRecipesByIngredients(List<string> ingredients)
        {
            // Logic to fetch recipes based on provided ingredients
            return new List<string>(); // Placeholder return
        }

        // Method to choose a diet preference
        public void ChooseDietPreference(string diet)
        {
            // Logic to set user's diet preference
        }

        public UserDietPreference UserDietPreference
        {
            get => default;
            set
            {
            }
        }

        public MealPlan MealPlan
        {
            get => default;
            set
            {
            }
        }

        public UserFavorites UserFavorites
        {
            get => default;
            set
            {
            }
        }

        public ShoppingList ShoppingList
        {
            get => default;
            set
            {
            }
        }

        public FridgeInventory FridgeInventory
        {
            get => default;
            set
            {
            }
        }
    }
}
