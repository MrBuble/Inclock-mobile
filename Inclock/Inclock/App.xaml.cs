﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;


namespace Inclock
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (BL.Login.Autenticar())
                MainPage = new View.master.Menu();
            else
                MainPage =new NavigationPage( new View.LoginPage());
            //    MainPage = new View.master.Menu();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            base.OnSleep();
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


    }
}
