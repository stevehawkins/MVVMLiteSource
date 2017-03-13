using mvvmLiteExample.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace mvvmLiteExample
{
	public partial class App : Application
	{
        public static ServiceMdl Locator;
        public App ()
		{
			InitializeComponent();

            Locator = new ServiceMdl();
            var firstPage = new NavigationPage(new LoginView());
            Locator.navigationService.Initialize(firstPage);
            Locator.dialogService.Initialize(firstPage);
            MainPage = firstPage;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
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
