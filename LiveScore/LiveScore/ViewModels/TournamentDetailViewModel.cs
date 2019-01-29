using System;

using LiveScore.Models;

namespace LiveScore.ViewModels
{
    public class TournamentDetailViewModel : BaseViewModel
    {
        public Tournament Item { get; set; }

        public TournamentDetailViewModel(Tournament item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}