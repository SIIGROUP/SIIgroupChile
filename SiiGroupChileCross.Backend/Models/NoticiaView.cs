using SiiGroupChileCross.Common.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiiGroupChileCross.Backend.Models
{
    public class NoticiaView : Noticias

    {
        public HttpPostedFileBase ImageFile { get; set; }
        public HttpPostedFileBase ImageFile1 { get; set; }
        public HttpPostedFileBase ImageFile2 { get; set; }
        public HttpPostedFileBase ImageFile3 { get; set; }
        public HttpPostedFileBase ImageFile4 { get; set; }

    }

}