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
        private View[] _views;
        public DescDiet ()
		{
			InitializeComponent ();
            _views = new View[]
         {
            new DescD(),
            new DescD(),
            new DescD()
         };
            Carousel.ItemsSource = _views;
           

        }
	}
}