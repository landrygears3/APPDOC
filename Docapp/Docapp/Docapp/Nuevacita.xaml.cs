using Plugin.Toast;
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
	public partial class Nuevacita : ContentPage
	{
        HoraMV HMV;
        public Nuevacita ()
		{
			InitializeComponent ();
            this.BindingContext = HMV = new HoraMV();
            btnface.Clicked += Btnface_Clicked;
            btninst.Clicked += Btninst_Clicked;
            btntel.Clicked += Btntel_Clicked;
            btnagn.Clicked += Btnagn_Clicked;
            hor.SelectedIndex = 0;

        }

        private void Btnagn_Clicked(object sender, EventArgs e)
        {
            String msn = "Debes llenar el/los campos:\n";
            Boolean aux = true;
            if (nom.Text.Length == 0)
            {
                msn += "Nombre \n";
                aux = false;
            }
            if (tel.Text.Length == 0)
            {
                msn += "Telefono \n";
                aux = false;
            }
            if (cor.Text.Length == 0)
            {
                msn += "Correo \n";
                aux = false;
            }
            if (hor.SelectedIndex == 0)
            {
                msn += "Hora \n";
                aux = false;
            }

            if (HMV.fechVal())
            {
                DisplayAlert("Oops!", "La fecha debe de ser mayor a hoy\n Si desea agendar hoy comuniquese por telefono.", "Aceptar");
                aux = false;
            }
            
            if (aux)
            {
                confirm();
            }
            else {
                DisplayAlert("Oops!", msn, "Aceptar");
            }
        }
        private void onSelDate(object sender, EventArgs e)
        {
            HMV.HorChan(dcatef.Date);
            hor.SelectedIndex=0;
            
        }

        private async void confirm()
        {
            var answer = await DisplayAlert("Agendar", "Se agendará una cita el dia: \n "+ dcatef.Date.ToString()
                , "Aceptar", "Cancelar");
            if (answer)
            {
                String aux=HMV.agendaA(nom.Text,tel.Text,cor.Text,hor.SelectedIndex);
                CrossToastPopUp.Current.ShowToastMessage(aux);
            }
        }

        private void Btntel_Clicked(object sender, EventArgs e)
        {
           Device.OpenUri(new Uri("Tel:4777168965"));
        }

        private void Btninst_Clicked(object sender, EventArgs e)
        {
             DisplayAlert("Atenciòn!!!", "Instagram no disponible. Marcanos o accede a faceboock.", "Entiendo!");
        }

        private void Btnface_Clicked(object sender, EventArgs e)
        {
               Device.OpenUri(new Uri("fb://drfelipeledezma/2018410341720091"));
        }
    }
}