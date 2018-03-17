using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Models
{
    public class Ingredients
    {
        public int Id { get; set; }
        public string NameIngredient { get; set; }

        public Prescriptions Prescriptions { get; set; }
    }
}
