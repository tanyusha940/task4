using System;

using Xamarin.Models;

namespace Xamarin.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Cocktails Item { get; set; }
        public ItemDetailViewModel(Cocktails item = null)
        {
            Title = item?.Name;
            Item = item;
        }
    }
}
