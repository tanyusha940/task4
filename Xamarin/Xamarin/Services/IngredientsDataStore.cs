using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Models;

[assembly: Xamarin.Forms.Dependency(typeof(Xamarin.Services.IngredientsDataStore))]
namespace Xamarin.Services
{
    class IngredientsDataStore : IDataStore<Ingredients>
    {
        List<Ingredients> ingredients;
        public IngredientsDataStore()
        {
            ingredients = new List<Ingredients>();
            var ingredientsItems = new List<Ingredients>
            {
                new Ingredients{Id = 1, NameIngredient = "Шотландский виски"},
                new Ingredients{Id = 2, NameIngredient = "Драмбуи"},
                new Ingredients{Id = 3, NameIngredient = "Водка"},
                new Ingredients{Id = 4, NameIngredient = "Кофейный ликер"},
                new Ingredients{Id = 5, NameIngredient = "Бурбон"},
                new Ingredients{Id = 6, NameIngredient = "Сахарный сироп"},
                new Ingredients{Id = 7, NameIngredient = "Лимонный сок"},
                new Ingredients{Id = 8, NameIngredient = "Лимон"},
                new Ingredients{Id = 9, NameIngredient = "Апельсиновая цедра"},
                new Ingredients{Id = 10, NameIngredient = "Апельсин"},

            };
            foreach(var item in ingredientsItems)
            {
                ingredients.Add(item);
            }
        }
        public async Task<bool> AddItemAsync(Ingredients item)
        {
            ingredients.Add(item);

            return await Task.FromResult(true);
        }
        public async Task<Ingredients> GetItemAsync(int id)
        {
            return await Task.FromResult(ingredients.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Ingredients>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(ingredients);
        }
    }
}
