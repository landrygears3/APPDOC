using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Docapp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnenter.Clicked += Btnenter_Clicked;
        }

        private void Btnenter_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Conjunto());
        }
    }
}
