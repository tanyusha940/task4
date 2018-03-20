using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamarin.Models;

namespace Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewItemPage : ContentPage
    {
        private StackLayout stackLayout = new StackLayout();
        public Cocktails Item { get; set; }
        //Dictionary<string, int> a
        public NewItemPage( List<string> name, List<int> amount)
        {
            InitializeComponent();

            Item = new Cocktails
            {
                Name = "Item name"
            };

            //showIngridients(amount, first);
            var a = "";
            var b = "";
            //int length = name.Count;

            for (int i = 0; i < name.Count; i++)
            {
                a += name[i].ToString() + " ";
                b += amount[i].ToString() + " ";

            }
            
            firstIngredient.Text = name[0].ToString();
            firstAmount.Text = amount[0].ToString();
            secondIngredient.Text = name[1].ToString();
            secondAmount.Text = amount[1].ToString();
            thirdIngredient.Text = name[2].ToString();
            thirdAmount.Text = amount[2].ToString();
            fourthIngredient.Text = name[3].ToString();
            fourthAmount.Text = amount[3].ToString();
            BindingContext = this;
        }

        private void showIngridients(List<string> total, int coef)
        {
            for (int i = 0; i < total.Count; i++)
            {
                stackLayout.Children.Add(new Label
                {
                    Text = "Ingridients for : " + total.ToString(),

                });
                //Read_From_File(total.ElementAt(i) + ".txt", coef);
            }
        }
    }
}