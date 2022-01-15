﻿using Pitaru_Cosmin_Lab12_xamarin.Services;
using Pitaru_Cosmin_Lab12_xamarin.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pitaru_Cosmin_Lab12_xamarin.Data;

namespace Pitaru_Cosmin_Lab12_xamarin
{
    public partial class App : Application
    {

        public static ShoppingListDatabase Database { get; private set; }

        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
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
