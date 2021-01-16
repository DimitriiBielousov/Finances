using Finances.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Finances
{
	public partial class App : Application
	{
		static SqlLiteDb database;

		public static SqlLiteDb Database
		{
			get
			{
				if (database == null)
				{
					database = new SqlLiteDb();
				}
				return database;
			}
		}

		public App ()
		{
			InitializeComponent();
			MainPage = new NavigationPage(new MainPage());
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
