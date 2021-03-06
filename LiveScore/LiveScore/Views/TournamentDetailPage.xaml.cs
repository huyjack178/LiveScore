﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LiveScore.Models;
using LiveScore.ViewModels;
using System.Collections.Generic;

namespace LiveScore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TournamentDetailPage : ContentPage
    {
        private TournamentDetailViewModel viewModel;

        public TournamentDetailPage(TournamentDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public TournamentDetailPage()
        {
            InitializeComponent();

            var item = new Tournament
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new TournamentDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}