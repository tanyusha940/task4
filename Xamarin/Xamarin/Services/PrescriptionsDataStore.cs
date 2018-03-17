using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Models;

namespace Xamarin.Services
{
    class PrescriptionsDataStore : IDataStore<Prescriptions>
    {
        List<Prescriptions> prescriptions;

        public PrescriptionsDataStore()
        {
            prescriptions = new List<Prescriptions>();
            var prescriptionsItem = new List<Prescriptions>
            {
                new Prescriptions{Id = 1, IdCocktails = 1, IdIngredient = 1, AmountIngredient = 50 },
                new Prescriptions{Id = 2, IdCocktails = 1, IdIngredient = 2, AmountIngredient = 25 },
                new Prescriptions{Id = 3, IdCocktails = 2, IdIngredient = 3, AmountIngredient = 50 },
                new Prescriptions{Id = 4, IdCocktails = 2, IdIngredient = 4, AmountIngredient = 25 },
                new Prescriptions{Id = 5, IdCocktails = 3, IdIngredient = 5, AmountIngredient = 50 },
                new Prescriptions{Id = 6, IdCocktails = 3, IdIngredient = 6, AmountIngredient = 15 },
                new Prescriptions{Id = 7, IdCocktails = 3, IdIngredient = 7, AmountIngredient = 30 },
                new Prescriptions{Id = 8, IdCocktails = 3, IdIngredient = 8, AmountIngredient = 20 },
                new Prescriptions{Id = 9, IdCocktails = 4, IdIngredient = 2, AmountIngredient = 50 },
                new Prescriptions{Id = 10, IdCocktails = 4, IdIngredient = 9, AmountIngredient = 150 },
                new Prescriptions{Id = 11, IdCocktails = 4, IdIngredient = 10, AmountIngredient = 30 },
            };
            foreach(var item in prescriptionsItem)
            {
                prescriptions.Add(item);
            }
        }
        public async Task<bool> AddItemAsync(Prescriptions item)
        {
            prescriptions.Add(item);

            return await Task.FromResult(true);
        }
        public async Task<Prescriptions> GetItemAsync(int id)
        {
            return await Task.FromResult(prescriptions.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Prescriptions>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(prescriptions);
        }
    }
}
