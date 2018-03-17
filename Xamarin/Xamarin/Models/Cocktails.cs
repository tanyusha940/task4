using System;
using System.Collections.Generic;

namespace Xamarin.Models
{
    public class Cocktails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DegreesCocktail { get; set; }
        public int AmountCocktail { get; set; }
        public string ImageCocktails { get; set; }
        public bool IsChecked { get; set; }

        public ICollection<Prescriptions> Prescriptions { get; set; }

        public Cocktails()
        {
            Prescriptions = new List<Prescriptions>();
        }
    }
}