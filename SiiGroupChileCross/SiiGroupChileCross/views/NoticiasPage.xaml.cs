using GalaSoft.MvvmLight.Command;
using SiiGroupChileCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace SiiGroupChileCross.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NoticiasPage : ContentPage
	{
      


        public NoticiasPage ()
		{
			InitializeComponent ();
		}

       // private void TapGestureRecognizer_OnTapped(VerNoticiaPage verNoticiaPage)
       // {
       //     MainViewModel.GetInstance().VerNoticia = new VerNoticiasViewModel();
        //    Navigation.PushModalAsync(new  VerNoticiaPage());

//        }


    }
}