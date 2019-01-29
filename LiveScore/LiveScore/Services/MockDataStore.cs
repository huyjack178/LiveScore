using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiveScore.Models;
using Xamarin.Forms;

namespace LiveScore.Services
{
    public class MockDataStore : IDataStore<Tournament>
    {
        private List<Tournament> items;

        public MockDataStore()
        {
            items = new List<Tournament>();
            var mockItems = new List<Tournament>
            {
                new Tournament { Id = Guid.NewGuid().ToString(), Text = "Champions League", Description="This is an item description.", Image = "tab_feed.png" },
                new Tournament { Id = Guid.NewGuid().ToString(), Text = "Europa League", Description="This is an item description.",Image = "tab_feed.png" },
                new Tournament { Id = Guid.NewGuid().ToString(), Text = "Premiere League", Description="This is an item description.",Image = "tab_feed.png" },
                new Tournament { Id = Guid.NewGuid().ToString(), Text = "Bundesliga", Description="This is an item description.",Image = "tab_feed.png" },
                new Tournament { Id = Guid.NewGuid().ToString(), Text = "Laliga", Description="This is an item description.",Image = "tab_feed.png" },
                new Tournament { Id = Guid.NewGuid().ToString(), Text = "V-League", Description="This is an item description.",Image = "tab_feed.png" },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Tournament item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Tournament item)
        {
            var oldItem = items.Where((Tournament arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Tournament arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Tournament> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Tournament>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}