using System;
//using TripLog.Services;
using TripLog.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TripLog.ViewModels;
using TripLog.services;
using Ninject.Modules;
using Ninject;

namespace TripLog
{
    public partial class App : Application
    {
        public IKernel Kernel { get; set; }
        public App(params INinjectModule[] platformModules)
        {
            InitializeComponent();

            var mainPage = new NavigationPage(new MainPage());
            var navService = DependencyService.Get<INavService>() as XamarinFormsNavService;
            navService.XamarinFormsNav = mainPage.Navigation;
            navService.RegisterViewMapping(typeof(MainViewModel),
                   typeof(MainPage));
            navService.RegisterViewMapping(typeof(DetailViewModel),
                   typeof(DetailPage));
            navService.RegisterViewMapping(typeof(NewEntryViewModel),
                   typeof(NewEntryPage));

            MainPage = mainPage;


            //MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
