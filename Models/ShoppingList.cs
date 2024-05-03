using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipeApp_24.Models
{
    public class ShoppingList
    {
        public int ShoppingListId { get; set; }
        public int UserId { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Ingredient Ingredient { get; set; }

        // Method to add an item to the shopping list
        public void AddItem(User user, Ingredient ingredient, int quantity)
        {
            User = user;
            UserId = user.UserId;
            Ingredient = ingredient;
            IngredientId = ingredient.IngredientId;
            Quantity = quantity;
            // Additional logic (e.g., database insertion)
        }

        // Method to update an item in the shopping list
        public void UpdateItem(int quantity)
        {
            Quantity = quantity;
            // Additional logic (e.g., database update)
        }

        // Method to remove an item from the shopping list
        public void RemoveItem()
        {
            // Remove item logic (e.g., database deletion)
        }
    }
}

