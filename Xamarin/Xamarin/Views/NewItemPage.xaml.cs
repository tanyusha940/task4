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
        public Cocktails Item { get; set; }
        //Dictionary<string, int> a
        public NewItemPage(List<string> name, List<int> amount, int first)
        {
            InitializeComponent();

            Item = new Cocktails
            {
                Name = "Item name"
            };

            var a = "";
            int length = name.Count;

            for (int i = 0; i < name.Count; i++)
            {
                a +=name[i].ToString() + " ";
            }
            lolo.Text = name[0].ToString();
            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopModalAsync();
        }
    }
}