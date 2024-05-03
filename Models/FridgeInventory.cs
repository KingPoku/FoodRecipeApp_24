using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipeApp_24.Models
{
    public class FridgeInventory
    {
        public int FridgeInventoryId { get; set; }
        public int UserId { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; } // New attribute for expiration date

        // Method to add item to fridge inventory
        public void AddToFridgeInventory(int userId, int ingredientId, int quantity, DateTime expirationDate)
        {
            // Logic to add item to fridge inventory
        }

        // Method to remove item from fridge inventory
        public void RemoveFromFridgeInventory(int fridgeInventoryId)
        {
            // Logic to remove item from fridge inventory
        }

        // Method to get fridge inventory items for a user
        public List<FridgeInventory> GetFridgeInventoryItems(int userId)
        {
            // Logic to retrieve fridge inventory items for a user from the database
            return new List<FridgeInventory>(); // Placeholder return
        }
    }
}
