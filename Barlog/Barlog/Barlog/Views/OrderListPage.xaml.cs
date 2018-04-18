using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Barlog.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OrderListPage : ContentPage
	{
		public OrderListPage ()
		{
			InitializeComponent ();
//            orderListView.ItemsSource
		}

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        async void OnItemAdded(object Sender, EventArgs e)
        {

        }

        async void OnIncreaseAmount(object sender, EventArgs e)
        {

        }

    }
}