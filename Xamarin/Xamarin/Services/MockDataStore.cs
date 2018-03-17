using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Models;

[assembly: Xamarin.Forms.Dependency(typeof(Xamarin.Services.MockDataStore))]
namespace Xamarin.Services
{
    public class MockDataStore : IDataStore<Cocktails>
    {
        List<Cocktails> items;

        public MockDataStore()
        {
            items = new List<Cocktails>();
            var mockItems = new List<Cocktails>
            {
                new Cocktails { Id = 1, Name = "Ржавый гвоздь", DegreesCocktail = 30, AmountCocktail = 75, ImageCocktails = "http://res.cloudinary.com/task04/image/upload/v1520681415/rzhavyi_gvozd.jpg", IsChecked = false },
                new Cocktails { Id = 2, Name = "Черный русский",DegreesCocktail = 35, AmountCocktail = 37 ,ImageCocktails = "http://res.cloudinary.com/task04/image/upload/v1520681416/icon_chernyi_russkii-image-final.jpg", IsChecked = false},
                new Cocktails { Id = 3, Name = "Виски сауэр", DegreesCocktail = 40, AmountCocktail = 120,ImageCocktails = "http://res.cloudinary.com/task04/image/upload/v1520681417/icon_Classic-whiskey-sour1.jpg", IsChecked = false},
                new Cocktails { Id = 3, Name = "Отвертка", DegreesCocktail = 40, AmountCocktail = 120,ImageCocktails = "http://res.cloudinary.com/task04/image/upload/v1520681415/icon__DDE6586.jpg", IsChecked = false },

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

        public async Task<bool> UpdateItemAsync(Cocktails item)
        {
            var _item = items.Where((Cocktails arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(Cocktails item)
        {
            var _item = items.Where((Cocktails arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);

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