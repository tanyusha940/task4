using System;
using System.Collections;
using System.Collections.Generic;
using Xamarin.Models;

namespace Xamarin.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Cocktails Item { get; set; }
 
        public int Degrees { get; set; }
        public IEnumerable<Prescriptions> Prescriptions {get;set;}

        public ItemDetailViewModel(Cocktails item = null)
        {
            Title = item?.Name;
            Degrees = item.DegreesCocktail;
            Prescriptions = item.Prescriptions;
            //Item.DegreesCocktail = item.DegreesCocktail;

        }
    }
}
