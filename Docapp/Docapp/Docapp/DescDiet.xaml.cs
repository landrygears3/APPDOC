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
	public partial class DescDiet : ContentPage
	{
		public DescDiet (String des)
		{
			InitializeComponent ();
            lblinfo.Text = des;
		}
        public DescDiet()
        {
            InitializeComponent();

        }
    }
}