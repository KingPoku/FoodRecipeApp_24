using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipeApp_24.Models
{
    public class UserFavorites
    {
        public int UserFavoritesId { get; set; }
        public int UserId { get; set; }
        public int RecipeId { get; set; }

        // Method to add recipe to user's favorites
        public void AddToFavorites(int userId, int recipeId)
        {
            // Logic to add recipe to user's favorites
        }

        // Method to remove recipe from user's favorites
        public void RemoveFromFavorites(int userFavoritesId)
        {
            // Logic to remove recipe from user's favorites
        }

        // Method to get user's favorite recipes
        public List<int> GetUserFavorites(int userId)
        {
            // Logic to retrieve user's favorite recipes from the database
            return new List<int>(); // Placeholder return
        }
    }
}
