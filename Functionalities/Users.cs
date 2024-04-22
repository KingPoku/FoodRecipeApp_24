using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipeApp_24.Functionalities
{
    public class Users
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; private set; }

        public Users(string name, string email, string password) 
        { 
            Name = name;
            Email = email;
            Password = password;
        }

        public void ViewRecipe()
        {

        }

    }
}
