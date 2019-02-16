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
	public partial class Perfil : ContentPage
	{
		public Perfil ()
		{
			InitializeComponent ();
            btnconper.Clicked += Btnconper_Clicked;

        }

        private void Btnconper_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Pagina en construcción", "Aquí se podrá editar el perfil del usuario", "Entiendo!");
        }
    }
}