﻿namespace MauiApp8
{
    public partial class App : Application
    {
        public App()
        {
            Application.Current.UserAppTheme = AppTheme.Light;

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}