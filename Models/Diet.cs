using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipeApp_24.Models
{
    public class Diet
    {
        public int DietId { get; set; }
        public string Name { get; set; }

        // Method to create a new diet
        public void CreateDiet(string name)
        {
            Name = name;
            // Additional logic (e.g., database insertion)
        }

        // Method to update an existing diet
        public void UpdateDiet(string name)
        {
            Name = name;
            // Additional logic (e.g., database update)
        }

        // Method to delete a diet
        public void DeleteDiet()
        {
            // Delete diet logic (e.g., database deletion)
        }
    }
}
