using SiiGroupChileCross.Common.Models;
using SiiGroupChileCross.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SiiGroupChileCross.ViewModels
{
    public class VerNoticiasViewModel : BaseViewModel
    {

        #region Attribures
        private Noticias noticia;
        private ApiService apiService;

        private ImageSource imageSource;
        private ImageSource imageSource1;
        private ImageSource imageSource2;
        private ImageSource imageSource3;
        private ImageSource imageSource4;
        #endregion

        #region Properties

        public Noticias Noticias
        {
            get{ return this.noticia; }
            set { this.SetValue(ref this.noticia, value); }
        }
        #endregion

        #region Contructors
        public VerNoticiasViewModel(Noticias noticia)
        {
            this.apiService = new ApiService();
            this.noticia = noticia;
            this.imageSource = noticia.ImageFullPath;
            this.imageSource1 = noticia.ImageFullPath1;
            this.imageSource2 = noticia.ImageFullPath2;
            this.imageSource3 = noticia.ImageFullPath3;
            this.imageSource4 = noticia.ImageFullPath4;


        }

        #endregion
    }
}
