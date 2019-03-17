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
            bnewus.Clicked += Bnewus_Clicked;
        }

        private void Bnewus_Clicked(object sender, EventArgs e)
        {
            
            this.Navigation.PushModalAsync(new Nuevacita());
        }

        private void Btnenter_Clicked(object sender, EventArgs e)
        {

          

         Login dats = new Login();
            var pusr = usr.Text;
            var ppsw = psw.Text;
            try { dats.div(pusr, ppsw);
                DisplayAlert("Sos",credenciales.Cred,"Okay");
                if (!(string.IsNullOrEmpty(credenciales.Cred)))
                {
                    this.Navigation.PushModalAsync(new Conjunto(),false);
                }
                else { DisplayAlert("No prro no!!", "Epale no está registrado ", "Perdón apá."); }

            } catch (Exception  oi) {
                 DisplayAlert("Uups!","Error. No hay conexión \n"+oi,"Ah si stoy bien menso.");
            }
           
            

        
        }
    }
}
