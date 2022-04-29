using ReproSwipe.Services;
using ReproSwipe.Views;
using System;
using Xamarin.Forms;

namespace ReproSwipe
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new PageRepro();


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

        
    } //class

  
} //ns
