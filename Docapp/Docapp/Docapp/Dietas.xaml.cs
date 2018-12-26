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
	public partial class Dietas : ContentPage
	{
		public Dietas ()
		{
			InitializeComponent ();
            btndesayuno.Clicked += Btndesayuno_Clicked;
            btncomida.Clicked += Btncomida_Clicked;
            btncena.Clicked += Btncena_Clicked;
            btncolacion1.Clicked += Btncolacion1_Clicked;
            btncolacion2.Clicked += Btncolacion2_Clicked;
		}

        private void Btncolacion2_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new DescDiet("Colacion 2"));
        }

        private void Btncolacion1_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new DescDiet("Colacion 1"));
        }

        private void Btncena_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new DescDiet("Cena"));
        }

        private void Btncomida_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new DescDiet("Comida"));
        }

        private void Btndesayuno_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new DescDiet("Desayuno"));
        }
    }
}