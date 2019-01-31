namespace LiveScore.ViewModels
{
    using LiveScore.Models;
    using LiveScore.Views;
    using System;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Xamarin.Forms;

    public class TournamentViewModel : BaseViewModel
    {
        public ObservableCollection<Tournament> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public TournamentViewModel()
        {
            Title = "Browse";
            Items = new ObservableCollection<Tournament>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, Tournament>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item;
                Items.Add(newItem);

                await DataStore.AddItemAsync(newItem);
            });
        }

        private async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);

                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}