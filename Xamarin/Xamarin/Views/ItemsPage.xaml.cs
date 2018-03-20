using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamarin.Models;
using Xamarin.ViewModels;
using System.ComponentModel;

namespace Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemsPage : ContentPage, INotifyPropertyChanged
    {
        ItemsViewModel viewModel;
        ItemDetailViewModel itemDetail;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
            //BindingContext = itemDetail = new ItemDetailViewModel();
        }
        //private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    if (headerStepper != null)
        //        headerStepper.Text = String.Format("Будет пить: {0:F1}", e.NewValue);
        //}
        private void OnButtonClicked(object sender, System.EventArgs e)
        {
            
            //*Int32.Parse(step.Value.ToString())
            Button button = (Button)sender;
            //Dictionary<string, int> ing = new Dictionary<string, int>();

            //List<string> name = new List<string>();
            //List<int> amount = new List<int>();
            int first = (picker.SelectedIndex + 1) * 2;
            //foreach (var x in viewModel.Items)
            //{
            //    if (x.IsChecked == true)
            //    {
            //        foreach (var p in x.Prescriptions)
            //        {
            //            amount.Add(itemDetail.Item.AmountCocktail * first);
            //            name.Add(p.Ingredients.NameIngredient);
            //            ing.Add(p.Ingredients.NameIngredient, p.AmountIngredient);
            //        }
            //    }
            //}
            firstGrid.IsVisible = false;
            secondGrid.IsVisible = true;
            //await Navigation.PushAsync(new NewItemPage(name,amount,first));
        }
        void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            headerPickter.Text = "Вы выбрали: " + picker.Items[picker.SelectedIndex];
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Cocktails;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}