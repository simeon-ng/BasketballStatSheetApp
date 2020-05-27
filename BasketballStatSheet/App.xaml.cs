using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasketballStatSheet
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new WelcomePage())
            {
                BarBackgroundColor = Color.Transparent,
            };

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
