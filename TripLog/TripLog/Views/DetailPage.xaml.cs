using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;
using TripLog.Models;
using TripLog.ViewModels;
using TripLog.services;
using System.ComponentModel;

namespace TripLog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        DetailViewModel ViewModel => BindingContext as DetailViewModel;
        public DetailPage()
        {
            InitializeComponent();

            BindingContext = new DetailViewModel(DependencyService.Get<INavService>());

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (ViewModel != null)
            {
                ViewModel.PropertyChanged += OnViewModelPropertyChanged;
            }
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (ViewModel != null)
            {
                ViewModel.PropertyChanged -= OnViewModelPropertyChanged;
            }
        }
        void OnViewModelPropertyChanged(object sender,
       PropertyChangedEventArgs args)
        {
            if (args.PropertyName == nameof(DetailViewModel.Entry))
            {
                UpdateMap();
            }
        }


        void UpdateMap()
        {
            if (ViewModel.Entry == null)
            {
                return;
            }

            map.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(
                            ViewModel.Entry.Latitude,
                            ViewModel.Entry.Longitude),
                            Distance.FromMiles(.5)));

            map.Pins.Add(new Pin
            {
                Type = PinType.Place,
                Label = ViewModel.Entry.Title,
                Position = new Position(
                           ViewModel.Entry.Latitude,
                           ViewModel.Entry.Longitude)
            });
        }
    }
}