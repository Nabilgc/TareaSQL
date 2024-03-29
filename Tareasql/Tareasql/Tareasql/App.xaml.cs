﻿using System;
using Tareasql.ViewModels;
using Tareasql.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Tareasql
{
    public partial class App : Application
    {
        public static string FilePath;
        public App()
        {
            InitializeComponent();

        }
        public App(string filePath)
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ListaVentas());
            FilePath = filePath;

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
