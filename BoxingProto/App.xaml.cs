using BoxingProto.Classes;
using BoxingProto.Services;
using BoxingProto.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BoxingProto
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new FirstPage())
            {

            };
            
            Application.Current.Properties["WorkoutsLoaded"] = true;
            Application.Current.Properties["RoundsLoaded"] = true;

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
