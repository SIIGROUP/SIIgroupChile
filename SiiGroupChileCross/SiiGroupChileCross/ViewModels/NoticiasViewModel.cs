using GalaSoft.MvvmLight.Command;
using SiiGroupChileCross.Common.Models;
using SiiGroupChileCross.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SiiGroupChileCross.ViewModels
{
    
  public  class NoticiasViewModel : BaseViewModel
    {
     
        #region Attributes
        private ApiService apiService;

        private bool isRefreshing;
        private ObservableCollection<NoticiaItemViewModel> noticias;
        #endregion

        #region Properties


        public ObservableCollection<NoticiaItemViewModel> Noticias {
            get { return this.noticias; }
            set { this.SetValue(ref this.noticias, value); }
                
                }
       
        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { this.SetValue(ref this.isRefreshing, value); }
        }

        #endregion

        #region Constructors
        public NoticiasViewModel()
        {
            instance = this;
            this.apiService = new ApiService();
            this.LoadNoticias();
        }

        #endregion

        #region Singleton

        private static NoticiasViewModel instance;

        public static NoticiasViewModel GetInstance()
        {
            if(instance == null)
            {
                return new NoticiasViewModel();
            }
            return instance;
        }

        #endregion

        #region Methods
        private async void LoadNoticias()
        {
            string Fecha = DateTime.Now.ToShortDateString();
            this.IsRefreshing = true;
            var response = await this.apiService.GetList<Noticias>("https://internoapi.azurewebsites.net/", "api", "/Noticias");
            if(!response.IsSuccess)
            {
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert("Error", response.Message, "aceptar");
                return;
            }
            var list = (List<Noticias>)response.Result;
            var myList = list.Select(p => new NoticiaItemViewModel
            {
                Titulo = p.Titulo,
                ImagePath = p.ImagePath,
                ImagePath1 = p.ImagePath1,
                ImagePath2 = p.ImagePath2,
                ImagePath3 = p.ImagePath3,
                ImagePath4 = p.ImagePath4,
                Texto = p.Texto,
                Fecha = p.Fecha,

            });
            this.Noticias = new ObservableCollection<NoticiaItemViewModel>(myList.OrderByDescending(n=>n.NoticiaId));
            this.IsRefreshing = false;
        }
      
        #endregion

        #region Commands

        public ICommand  RefreshCommand
        {
            get
            {
                return new RelayCommand(LoadNoticias);
            }
            
        }
        #endregion
    }


}
