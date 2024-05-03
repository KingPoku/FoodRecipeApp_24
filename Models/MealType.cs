using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipeApp_24.Models
{
    public class MealType
    {
        public int MealTypeId { get; set; }
        public string Name { get; set; }

        // Method to create a new meal type
        public void CreateMealType(string name)
        {
            // Logic to create a new meal type
        }

        // Method to update an existing meal type
        public void UpdateMealType(int mealTypeId, string name)
        {
            // Logic to update an existing meal type
        }

        // Method to delete a meal type
        public void DeleteMealType(int mealTypeId)
        {
            // Logic to delete a meal type
        }

        // Method to get meal type details
        public MealType GetMealTypeDetails(int mealTypeId)
        {
            // Logic to retrieve meal type details from the database
            return new MealType(); // Placeholder return
        }
    }
}
