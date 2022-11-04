using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripLog.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TripLog.ViewModels;
using TripLog.services;

namespace TripLog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        MainViewModel ViewModel => BindingContext as MainViewModel;

        private IEnumerable items;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel(DependencyService.Get<INavService>());

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            // Initialize MainViewModel
            ViewModel?.Init();
        }


        //void New_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new NewEntryPage());
        //}

        //async void Trips_SelectionChanged(object s, SelectionChangedEventArgs e)
        //{
        //    var trip = (TripLogEntry)e.CurrentSelection.FirstOrDefault();
        //    if (trip != null)
        //    {
        //        await Navigation.PushAsync(new DetailPage(trip));
        //    }
        //    // Clear selection
        //    trips.SelectedItem = null;
        //}
    }
}