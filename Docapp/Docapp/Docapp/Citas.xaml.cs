﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Docapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Citas : ContentPage
    {
        HoraMV HMV;

        public Citas ()
		{
			InitializeComponent ();
            this.BindingContext = HMV = new HoraMV();
            DateTime PropertyMinimumDate = DateTime.Now;
            btnface.Clicked += Btnface_Clicked;
            btninst.Clicked += Btninst_Clicked;
            btntel.Clicked += Btntel_Clicked;
            btnagn.Clicked += Btnagn_Clicked;
        }
       

        private void Btnagn_Clicked(object sender, EventArgs e)
        {
         
            DisplayAlert("", datef.Date.ToString("yyyy/MM/dd"),"ok");
            String [] resp = HMV.div(datef.Date.ToString("yyyy/MM/dd"));
            String da = "";
            for (int i = 0; i < resp.Length; i++)
            {
                da += resp[i];
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