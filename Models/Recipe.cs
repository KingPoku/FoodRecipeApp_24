using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipeApp_24.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
        public string ImageUrl { get; set; }
        public string SourceApi { get; } = "Spoonacular"; // Set source API to Spoonacular

        // Navigation property to relate Recipe and RecipeIngredient
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }

        public RecipeIngredient RecipeIngredient
        {
            get => default;
            set
            {
            }
        }

        // Constructor
        public Recipe()
        {
            RecipeIngredients = new List<RecipeIngredient>();
        }

        // Method to create a new recipe
        public void CreateRecipe(string name, string description, string instructions, string imageUrl)
        {
            Name = name;
            Description = description;
            Instructions = instructions;
            ImageUrl = imageUrl;
            // Additional logic (e.g., database insertion)
        }

        // Method to update an existing recipe
        public void UpdateRecipe(string name, string description, string instructions, string imageUrl)
        {
            Name = name;
            Description = description;
            Instructions = instructions;
            ImageUrl = imageUrl;
            // Additional logic (e.g., database update)
        }

        // Method to delete a recipe
        public void DeleteRecipe()
        {
            // Delete recipe logic (e.g., database deletion)
        }

        // Method to add a review to the recipe
        public void AddReview(string review)
        {
            // Logic to add review to the recipe
        }
    }
}
