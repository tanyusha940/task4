using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Models;

[assembly: Xamarin.Forms.Dependency(typeof(Xamarin.Services.CocktailsDataStore))]
namespace Xamarin.Services
{
    public class CocktailsDataStore : IDataStore<Cocktails>
    {
        List<Cocktails> items;

        public CocktailsDataStore()
        {
            items = new List<Cocktails>();
            var ingredientsItems = new List<Ingredients>
            {
                new Ingredients{Id = 1, NameIngredient = "Шотландский виски"},
                new Ingredients{Id = 2, NameIngredient = "Драмбуи"},
                new Ingredients{Id = 3, NameIngredient = "Водка"},
                new Ingredients{Id = 4, NameIngredient = "Кофейный ликер"},
                new Ingredients{Id = 5, NameIngredient = "Бурбон"},
                new Ingredients{Id = 6, NameIngredient = "Сахарный сироп"},
                new Ingredients{Id = 7, NameIngredient = "Лимонный сок"},
                new Ingredients{Id = 8, NameIngredient = "Белый ром"},
                new Ingredients{Id = 9, NameIngredient = "Апельсиновая цедра"},
                new Ingredients{Id = 10, NameIngredient = "Апельсиновый сок"},
                new Ingredients{Id = 11, NameIngredient = "Апельсин"},

            };

            var prescriptionsItem = new List<Prescriptions>
            {
                new Prescriptions{Id = 1, IdCocktails = 1, IdIngredient = 1, AmountIngredient = 50, Ingredients = ingredientsItems[0] },
                new Prescriptions{Id = 2, IdCocktails = 1, IdIngredient = 2, AmountIngredient = 25, Ingredients = ingredientsItems[1] },
                new Prescriptions{Id = 3, IdCocktails = 2, IdIngredient = 3, AmountIngredient = 50, Ingredients = ingredientsItems[2] },
                new Prescriptions{Id = 4, IdCocktails = 2, IdIngredient = 4, AmountIngredient = 25, Ingredients = ingredientsItems[3] },
                new Prescriptions{Id = 5, IdCocktails = 3, IdIngredient = 5, AmountIngredient = 50, Ingredients = ingredientsItems[4] },
                new Prescriptions{Id = 6, IdCocktails = 3, IdIngredient = 6, AmountIngredient = 15 , Ingredients = ingredientsItems[5] },
                new Prescriptions{Id = 7, IdCocktails = 3, IdIngredient = 7, AmountIngredient = 30, Ingredients = ingredientsItems[6] },
                new Prescriptions{Id = 8, IdCocktails = 3, IdIngredient = 8, AmountIngredient = 20, Ingredients = ingredientsItems[7] },
                new Prescriptions{Id = 9, IdCocktails = 4, IdIngredient = 2, AmountIngredient = 50, Ingredients = ingredientsItems[2] },
                new Prescriptions{Id = 10, IdCocktails = 4, IdIngredient = 9, AmountIngredient = 150, Ingredients = ingredientsItems[9] },
                new Prescriptions{Id = 11, IdCocktails = 4, IdIngredient = 11, AmountIngredient = 30, Ingredients = ingredientsItems[10] },
            };

            var mockItems = new List<Cocktails>
            {
                new Cocktails { Id = 1, Name = "Ржавый гвоздь", DegreesCocktail = 30, AmountCocktail = 75, ImageCocktails = "http://res.cloudinary.com/task04/image/upload/v1520681415/rzhavyi_gvozd.jpg", IsChecked = false,
                Prescriptions = new List<Prescriptions>
                {
                    prescriptionsItem[0], prescriptionsItem[1]
                }},
                new Cocktails { Id = 2, Name = "Черный русский",DegreesCocktail = 35, AmountCocktail = 37 ,ImageCocktails = "http://res.cloudinary.com/task04/image/upload/v1520681416/icon_chernyi_russkii-image-final.jpg", IsChecked = false,
                Prescriptions = new List<Prescriptions>
                    {
                        prescriptionsItem[2], prescriptionsItem[3]
                    }},
                new Cocktails { Id = 3, Name = "Виски сауэр", DegreesCocktail = 40, AmountCocktail = 120,ImageCocktails = "http://res.cloudinary.com/task04/image/upload/v1520681417/icon_Classic-whiskey-sour1.jpg", IsChecked = false,
                Prescriptions = new List<Prescriptions>
                {
                    prescriptionsItem[4], prescriptionsItem[5], prescriptionsItem[6], prescriptionsItem[7]
                }},
                new Cocktails { Id = 4, Name = "Отвертка", DegreesCocktail = 40, AmountCocktail = 120,ImageCocktails = "http://res.cloudinary.com/task04/image/upload/v1520681415/icon__DDE6586.jpg", IsChecked = false ,
                Prescriptions = new List<Prescriptions>
                {
                    prescriptionsItem[8],prescriptionsItem[9],prescriptionsItem[10]
                }},
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Cocktails item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }


        public async Task<Cocktails> GetItemAsync(int id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Cocktails>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}