using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SiiGroupChileCross.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LinksPage : ContentPage
	{
		public LinksPage ()
		{
			InitializeComponent ();
		}
        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://bob.siigroup.cl/"));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://tiempos.siigroup.cl/"));
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://teamfoundation.siigroup.cl/tfs/"));
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://intranet.siigroup.cl/Paginas/Comite_Paritario.aspx"));
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://zoho.com/recruit/login.html"));
        }


      
    }
}