using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Barlog.Data;
using Xamarin.Forms;

namespace Barlog
{
	public partial class App : Application
	{
        static OrderItemDatabase database;

        public static OrderItemDatabase Database
        {
            get
            {
                return null;
                if (database == null)
                {
//                    database = new OrderItemDatabase(DependencyService.Get)
                }
            }
        }
		public App ()
		{
			InitializeComponent();

            var nav = new NavigationPage(new Views.OrderListPage());
            nav.BarBackgroundColor = Color.CadetBlue;
            nav.BarTextColor = Color.White;

            MainPage = nav;
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
