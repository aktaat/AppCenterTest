using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Xamarin.Forms;

namespace App1
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new App1.MainPage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            AppCenter.Start($"android=0be8575e-eba4-413c-9627-538337758c25;ios=ce088951-7fd5-45cd-b592-f39684ba216e",
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
