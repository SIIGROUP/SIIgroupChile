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
	public partial class VerNoticiaPage : ContentPage
	{
		public VerNoticiaPage ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage());
        }
    }
}