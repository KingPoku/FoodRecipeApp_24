using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FoodRecipeApp_24.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public User User
        {
            get => default;
            set
            {
            }
        }

        public Recipe Recipe
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

        public UserDietPreference UserDietPreference
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

        private string _hashedPassword; // Store hashed password

        // Constructor
        public Admin(int adminId, string username, string email, string password)
        {
            AdminId = adminId;
            Username = username;
            Email = email;
            _hashedPassword = HashPassword(password); // Hash the provided password
        }

        // Method to authenticate admin login
        public bool Login(string usernameOrEmail, string password)
        {
            // Check if provided username or email matches admin's credentials
            if ((usernameOrEmail == Username || usernameOrEmail == Email) && VerifyPassword(password, _hashedPassword))
            {
                return true; // Login successful
            }
            return false; // Login failed
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
        private bool VerifyPassword(string password, string hashedPassword)
        {
            string hashedInput = HashPassword(password);
            return hashedInput == hashedPassword;
        }

        // Method to delete admin account
        public void DeleteAccount()
        {
            // Delete admin account logic (e.g., database deletion)
        }

        // Method to change admin password
        public void ChangePassword(string newPassword)
        {
            _hashedPassword = HashPassword(newPassword);
            // Additional logic (e.g., update password in database)
        }

        // Method to view user accounts
        public void ViewUserAccounts()
        {
            // Logic to retrieve and display user accounts
        }

        // Method to view recipes
        public void ViewRecipes()
        {
            // Logic to retrieve and display recipes
        }

        // Method to approve user reviews
        public void ApproveUserReviews()
        {
            // Logic to approve user reviews
        }

        // Method to manage site settings
        public void ManageSiteSettings()
        {
            // Logic to manage site settings (e.g., change site configuration)
        }

        // Method to generate reports
        public void GenerateReports()
        {
            // Logic to generate various reports (e.g., user activity, recipe popularity)
        }

        // Method to log out
        public void Logout()
        {
            // Perform logout actions (if any)
        }
    }
}
