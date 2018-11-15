using SiiGroupChileCross.Interfaces;
using SiiGroupChileCross.ViewModels;
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
	public partial class Incio : ContentPage
	{
		public Incio ()
		{
			InitializeComponent ();

            

        }
        public void RegisterDevice()
        {
            var register = DependencyService.Get<IRegisterDevice>();
            register.RegisterDevice();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage());
            MainViewModel.GetInstance().RegisterDevice();
        }
    }
}