//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Net.Http;
//using Newtonsoft.Json;
//using FoodRecipeApp_24.Models;

//namespace FoodRecipeApp_24
//{
//    public class SpoonacularApi
//    {
//        private const string BaseUrl = "https://api.spoonacular.com/";
//        private readonly string _apiKey;
//        private readonly HttpClient _httpClient;

//        public SpoonacularApi(string apiKey)
//        {
//            _apiKey = apiKey;
//            _httpClient = new HttpClient { BaseAddress = new Uri(BaseUrl) };
//        }

//        private async Task<T> GetAsync<T>(string endpoint)
//        {
//            try
//            {
//                var response = await _httpClient.GetAsync($"{endpoint}?apiKey={_apiKey}");
//                response.EnsureSuccessStatusCode();

//                var jsonString = await response.Content.ReadAsStringAsync();
//                return JsonConvert.DeserializeObject<T>(jsonString);
//            }
//            catch (HttpRequestException ex)
//            {
//                // Handle HTTP request errors
//                throw new ApplicationException("Error occurred while making an API request.", ex);
//            }
//            catch (JsonException ex)
//            {
//                // Handle JSON serialization/deserialization errors
//                throw new ApplicationException("Error occurred while processing API response.", ex);
//            }
//        }

//        public async Task<RecipeResponse> GetRecipeByIdAsync(int recipeId)
//        {
//            return await GetAsync<RecipeResponse>($"recipes/{recipeId}/information");
//        }

//        public async Task<SearchRecipeResponse> SearchRecipesAsync(string query, int number = 10)
//        {
//            return await GetAsync<SearchRecipeResponse>($"recipes/search?query={query}&number={number}");
//        }

//        public async Task<SearchRecipeResponse> GetRandomRecipesAsync(int number = 10)
//        {
//            return await GetAsync<SearchRecipeResponse>($"recipes/random?number={number}");
//        }

//        public async Task<IngredientResponse> GetIngredientByIdAsync(int ingredientId)
//        {
//            return await GetAsync<IngredientResponse>($"food/ingredients/{ingredientId}/information");
//        }
//    }
//}
