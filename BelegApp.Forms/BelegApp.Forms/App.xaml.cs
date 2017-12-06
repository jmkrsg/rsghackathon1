﻿using BelegApp.Forms.Models;
using BelegApp.Forms.Services;
using BelegApp.Forms.Utils;
using BelegApp.Forms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BelegApp.Forms
{
	public partial class App : Application
	{
        private BelegMasterViewModel _belegMasterViewModel;
		public App ()
		{
			InitializeComponent();
            
            MainPage = new NavigationPage(new BelegApp.Forms.Views.MainPage());
		}

		protected override void OnStart ()
		{
            StaticValues.UpdateStaticValues();
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
            StaticValues.UpdateStaticValues();
        }


        private async Task getBelegList()
        {
            // Belegliste online holen
            Beleg[] belegList = Storage.Database.GetBelege().Result;
            BelegMasterViewModel = new BelegMasterViewModel(MainPage.Navigation, belegList);
            MainPage.BindingContext = BelegMasterViewModel;
        }
	}
}
