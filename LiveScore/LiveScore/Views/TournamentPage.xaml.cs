using LiveScore.Models;
using LiveScore.ViewModels;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LiveScore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TournamentPage : ContentPage
    {
        private TournamentViewModel viewModel;

        public TournamentPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new TournamentViewModel();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (!(args.SelectedItem is Tournament item))
            {
                return;
            }

            await Navigation.PushAsync(new TournamentDetailPage(new TournamentDetailViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        private void OnSearchBarTextChanged(object sender, TextChangedEventArgs args)
        {
            if (!string.IsNullOrEmpty(args.NewTextValue))
            {
                ItemsListView.ItemsSource = viewModel.Items.Where(item => item.Text.StartsWith(args.NewTextValue));
            }
            else
            {
                ItemsListView.ItemsSource = viewModel.Items;
            }
        }

        private async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
            {
                viewModel.LoadItemsCommand.Execute(null);
            }
        }
    }
}