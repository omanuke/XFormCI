using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace XFormCI
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

		    MainPage = new NavigationPage(new MainPage());
        }

		protected override void OnStart ()
		{
            // Handle when your app starts
		    AppCenter.Start("android=16ce8137-548f-43bb-b8fc-4b0b2695419f;",
		        typeof(Analytics), typeof(Crashes));
		}

        protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
