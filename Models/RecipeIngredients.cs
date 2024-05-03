using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace FoodRecipeApp_24.Models
    {
        public class RecipeIngredient
        {
            public int RecipeIngredientId { get; set; }
            public int RecipeId { get; set; }
            public int IngredientId { get; set; }
            public int Quantity { get; set; }

            // Navigation properties
            public Recipe Recipe { get; set; }
            public Ingredient Ingredient { get; set; }

            // Method to associate ingredient with recipe
            public void AssociateIngredientWithRecipe(Recipe recipe, Ingredient ingredient, int quantity)
            {
                Recipe = recipe;
                Ingredient = ingredient;
                Quantity = quantity;
                // Additional logic (e.g., database insertion)
            }

            // Method to disassociate ingredient from recipe
            public void DisassociateIngredientFromRecipe()
            {
                // Logic to remove association from database
            }

            // Method to get ingredients for a recipe
            public List<Ingredient> GetIngredientsForRecipe(int recipeId)
            {
                // Logic to retrieve ingredients for a recipe from the database
                return new List<Ingredient>(); // Placeholder return
            }
        }

    }
