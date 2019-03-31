using Autofac.Core;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFormsAppDesignTwo.Base;
using XFormsAppDesignTwo.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XFormsAppDesignTwo
{
    public partial class App : Application
    {
        public App(IModule platformModule)
        {
            LocatorBase.Register(platformModule, false);
            InitializeComponent();
            MainPage = new MainPage();
        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
