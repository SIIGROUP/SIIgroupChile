using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiiGroupChileCross.Common.Models
{
  public  class Noticias
    {
        [Key]
        public int NoticiaId { get; set; }
        [Required]
        public string Titulo { get; set; }

        public string Texto { get; set; }


        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImagePath))
                {
                    return null;
                }
                return $"https://internobackend20181025122808.azurewebsites.net/{this.ImagePath.Substring(1)}";
            }
        }
        public string ImageFullPath1
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImagePath1))
                {
                    return null;
                }
                return $"https://internobackend20181025122808.azurewebsites.net/{this.ImagePath1.Substring(1)}";
            }
        }
        public string ImageFullPath2
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImagePath2))
                {
                    return null;
                }
                return $"https://internobackend20181025122808.azurewebsites.net/{this.ImagePath2.Substring(1)}";
            }
        }
        public string ImageFullPath3
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImagePath3))
                {
                    return null;
                }
                return $"https://internobackend20181025122808.azurewebsites.net/{this.ImagePath3.Substring(1)}";
            }
        }
        public string ImageFullPath4
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImagePath4))
                {
                    return null;
                }
                return $"https://internobackend20181025122808.azurewebsites.net/{this.ImagePath4.Substring(1)}";
            }
        }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm}")]

        public DateTime Fecha { get; set; }

        [Display(Name = "Image")]
        public string ImagePath { get; set; }
        [Display(Name = "Image2")]
        public string ImagePath1 { get; set; }
        [Display(Name = "Image3")]
        public string ImagePath2 { get; set; }
        [Display(Name = "Image4")]
        public string ImagePath3 { get; set; }
        [Display(Name = "Image5")]
        public string ImagePath4 { get; set; }
        public override string ToString()
        {
            return this.Titulo;
        }
    }
}
