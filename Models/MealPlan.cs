using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipeApp_24.Models
{
    public class MealPlan
    {
        public int MealPlanId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } // Navigation property for User
        public DateTime Date { get; set; }
        public int MealTypeId { get; set; }
        public MealType MealType { get; set; } // Navigation property for MealType
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; } // Navigation property for Recipe

        // Method to create a new meal plan
        public void CreateMealPlan(User user, DateTime date, MealType mealType, Recipe recipe)
        {
            UserId = user.UserId;
            Date = date;
            MealTypeId = mealType.MealTypeId;
            RecipeId = recipe.RecipeId;
            // Additional logic (e.g., database insertion)
        }

        // Method to update an existing meal plan
        public void UpdateMealPlan(int mealPlanId, DateTime date, MealType mealType, Recipe recipe)
        {
            Date = date;
            MealTypeId = mealType.MealTypeId;
            RecipeId = recipe.RecipeId;
            // Additional logic (e.g., database update)
        }

        // Method to delete a meal plan
        public void DeleteMealPlan(int mealPlanId)
        {
            // Logic to delete a meal plan
        }

        // Method to get meal plans for a user
        public List<MealPlan> GetMealPlans(int userId)
        {
            // Logic to retrieve meal plans for a user from the database
            return new List<MealPlan>(); // Placeholder return
        }
    }
}
