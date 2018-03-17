using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Models
{
    public class Prescriptions
    {
        public int Id { get; set; }
        public int? IdCocktails { get; set; }
        public int IdIngredient { get; set; }
        public int AmountIngredient { get; set; }

        public Cocktails Cocktails { get; set; }
        public Ingredients Ingredients { get; set; }
    }
}
