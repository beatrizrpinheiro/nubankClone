using NubankClone.ViewModels;
using NubankClone.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NubankClone
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            BindingContext = new HelpMeViewModel();

            //MainPage = new MainPage();
            //MainPage = new InitialPage();
            //MainPage = new NavigationPage(new PhysicalCard());
            MainPage = new HelpMe();
            
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
