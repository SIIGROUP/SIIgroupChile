using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace SiiGroupChileCross.Backend.Herlpers
{
    public static class FileHelper
    {
        public static string UploadPhoto(HttpPostedFileBase file,   string folder)
        {
            string path = string.Empty;
            string pic = string.Empty;

            if (file != null)
            {
                pic = Path.GetFileName(file.FileName);
                path = Path.Combine(HttpContext.Current.Server.MapPath(folder), pic);
                file.SaveAs(path);
            }

            return pic;
        }
        public static string UploadPhoto1(HttpPostedFileBase file1, string folder)
        {
            string path1 = string.Empty;
            string pic1 = string.Empty;

            if (file1 != null)
            {
                pic1 = Path.GetFileName(file1.FileName);
                path1 = Path.Combine(HttpContext.Current.Server.MapPath(folder), pic1);
                file1.SaveAs(path1);
            }

            return pic1;
        }
        public static string UploadPhoto2(HttpPostedFileBase file2, string folder)
        {
            string path2 = string.Empty;
            string pic2 = string.Empty;

            if (file2 != null)
            {
                pic2 = Path.GetFileName(file2.FileName);
                path2 = Path.Combine(HttpContext.Current.Server.MapPath(folder), pic2);
                file2.SaveAs(path2);
            }

            return pic2;
        }
        public static string UploadPhoto3(HttpPostedFileBase file3, string folder)
        {
            string path3 = string.Empty;
            string pic3 = string.Empty;

            if (file3 != null)
            {
                pic3 = Path.GetFileName(file3.FileName);
                path3 = Path.Combine(HttpContext.Current.Server.MapPath(folder), pic3);
                file3.SaveAs(path3);
            }

            return pic3;
        }
        public static string UploadPhoto4(HttpPostedFileBase file4, string folder)
        {
            string path4 = string.Empty;
            string pic4 = string.Empty;

            if (file4 != null)
            {
                pic4 = Path.GetFileName(file4.FileName);
                path4 = Path.Combine(HttpContext.Current.Server.MapPath(folder), pic4);
                file4.SaveAs(path4);
            }

            return pic4;
        }

    }
}