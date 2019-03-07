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
    public partial class Conjunto : TabbedPage
    {
        public Conjunto ()
        {
            InitializeComponent();
        }
        protected override bool OnBackButtonPressed()
        {
            base.OnBackButtonPressed();

            return false;

}
    }
}