﻿    using System;
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
		public Citas ()
		{
			InitializeComponent ();
            bhora.Clicked += Bhora_Clicked;

        }

        private void Bhora_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}