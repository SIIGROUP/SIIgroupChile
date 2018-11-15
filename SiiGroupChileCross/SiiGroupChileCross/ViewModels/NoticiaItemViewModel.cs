using SiiGroupChileCross.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SiiGroupChileCross.Services;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;
using SiiGroupChileCross.views;

namespace SiiGroupChileCross.ViewModels
{
    public class NoticiaItemViewModel : Noticias
    {
        #region Attibutes
        private ApiService apiServices;
        #endregion

        #region Contructors
        public NoticiaItemViewModel()
        {
            this.apiServices = new ApiService();
        }
        #endregion
        #region Commands
        public ICommand VerNoticiaCommand
        {
            get
            {
                return new RelayCommand(VerNoticia);
            }
        }

        private async void VerNoticia()
        {
            MainViewModel.GetInstance().VerNoticia = new VerNoticiasViewModel(this);
            await Application.Current.MainPage.Navigation.PushModalAsync(new VerNoticiaPage());

        }
        #endregion


    }
}
