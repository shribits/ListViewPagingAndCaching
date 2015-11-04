using System;

using Xamarin.Forms;
using XLabs.Forms.Mvvm;

namespace Yahooooo
{
	public class App : Application
	{
		static CacheService database;
		public static CacheService Database {
			get { 
				if (database == null) {
					database = new CacheService ();
				}
				return database; 
			}
		}
		public App ()
		{
			ViewFactory.Register<ExamplePage, ExampleViewModel>();
			// The root page of your application
			MainPage = new NavigationPage(ViewFactory.CreatePage<ExampleViewModel, ExamplePage>() as Page);
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

