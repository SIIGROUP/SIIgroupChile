using SiiGroupChileCross.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SiiGroupChileCross.ViewModels
{
    public class MainViewModel
    {

        #region Properties
        public VerNoticiasViewModel VerNoticia { get; set; }
        public NoticiasViewModel Noticias { get; set; }

        #endregion


        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Noticias = new NoticiasViewModel();

        }
        #endregion


        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new MainViewModel();
            }

            return instance;
        }
        #endregion
        public void RegisterDevice()
        {
            var register = DependencyService.Get<IRegisterDevice>();
            register.RegisterDevice();
        }




    }


}
