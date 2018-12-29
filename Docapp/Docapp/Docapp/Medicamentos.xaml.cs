using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Docapp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Medicamentos : ContentPage
	{
		public Medicamentos ()
		{
			InitializeComponent ();
		}
        private void ListViewItem_Tabbed(object sender, ItemTappedEventArgs e)
        {
            var product = e.Item as Product;
            var vm = BindingContext as MainListView;
            vm?.ShoworHiddenProducts(product);
        }
    }
}