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

           // this.Navigation.PushModalAsync(new Conjunto());

         Login dats = new Login();
            var pusr = usr.Text;
            var ppsw = psw.Text;
            try { Boolean dat = dats.div(pusr, ppsw);
                if (dat)
                {
                    DisplayAlert("La División es", "Simón"+dat, "Ay si muy vergas");
                    this.Navigation.PushModalAsync(new Conjunto());
                }
                else { DisplayAlert("No prro no!!", "Epale no está registrado" + dat, "Perdón apá."); }

            } catch (Exception  oi) {
                 DisplayAlert("Uups!","No se pudo iniciar seción por que no estás registrado.","Ah si stoy bien menso.");
            }
           
            

        
        }
    }
}
