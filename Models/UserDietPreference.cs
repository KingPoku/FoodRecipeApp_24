using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipeApp_24.Models
{
    public class UserDietPreference
    {
        public int UserDietPreferenceId { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; } // Navigation property to represent the user

        public int DietId { get; set; }
        [ForeignKey("DietId")]
        public Diet Diet { get; set; } // Navigation property to represent the diet

        // Method to set user's diet preference
        public void SetDietPreference(int userId, int dietId)
        {
            // Logic to set user's diet preference
        }

        // Method to get user's diet preference
        public int GetUserDietPreference(int userId)
        {
            // Logic to retrieve user's diet preference from the database
            return 0; // Placeholder return
        }
    }
}
