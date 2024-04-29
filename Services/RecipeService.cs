//using FoodRecipeApp_24.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



//namespace FoodRecipeApp_24.Services
//{
//    public class RecipeService
//    {
//        private readonly SpoonacularApi _apiClient;

//        public RecipeService(string apiKey)
//        {
//            _apiClient = new SpoonacularApi(apiKey);
//        }

//        public async Task<RecipeResponse> GetRecipeById(int recipeId)
//        {
//            try
//            {
//                return await _apiClient.GetRecipeByIdAsync(recipeId);
//            }
//            catch (Exception ex)
//            {
//                // Log the error (e.g., using a logging library)
//                // Handle or display the error message to the user
//                throw new ApplicationException("Error occurred while fetching recipe by ID.", ex);
//            }
//        }

//        public async Task<SearchRecipeResponse> SearchRecipes(string query)
//        {
//            try
//            {
//                return await _apiClient.SearchRecipesAsync(query);
//            }
//            catch (Exception ex)
//            {
//                // Log the error (e.g., using a logging library)
//                // Handle or display the error message to the user
//                throw new ApplicationException("Error occurred while searching recipes.", ex);
//            }
//        }

//        public async Task<SearchRecipeResponse> GetRandomRecipes(int number = 10)
//        {
//            try
//            {
//                return await _apiClient.GetRandomRecipesAsync(number);
//            }
//            catch (Exception ex)
//            {
//                // Log the error (e.g., using a logging library)
//                // Handle or display the error message to the user
//                throw new ApplicationException("Error occurred while fetching random recipes.", ex);
//            }
//        }

//        public async Task<IngredientResponse> GetIngredientById(int ingredientId)
//        {
//            try
//            {
//                return await _apiClient.GetIngredientByIdAsync(ingredientId);
//            }
//            catch (Exception ex)
//            {
//                // Log the error (e.g., using a logging library)
//                // Handle or display the error message to the user
//                throw new ApplicationException("Error occurred while fetching ingredient by ID.", ex);
//            }
//        }
//    }
//}