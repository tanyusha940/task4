using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Xamarin.Services
{
    public interface IDataStore<T>
    {
        Task<T> GetItemAsync(int id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
