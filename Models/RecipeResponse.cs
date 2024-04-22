using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipeApp_24.Models
{
    public class RecipeResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Instructions { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();
    }
}
