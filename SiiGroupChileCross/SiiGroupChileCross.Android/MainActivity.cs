using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Plugin.Permissions;

namespace SiiGroupChileCross.Droid
{
    [Activity(Label = "SiiGroup", Icon = "@drawable/logo200", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        #region Singleton
        private static MainActivity instance;

        public static MainActivity GetInstance()
        {
            if (instance == null)
            {
                instance = new MainActivity();
            }

            return instance;
        }
        #endregion


        #region Methods

        protected override void OnCreate(Bundle savedInstanceState)
        {
            instance = this;



            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }

        public override void OnRequestPermissionsResult(
    int requestCode,
    string[] permissions,
    [GeneratedEnum] Permission[] grantResults)
        {
            PermissionsImplementation.Current.OnRequestPermissionsResult(
                requestCode,
                permissions,
                grantResults);
        }
        #endregion

    }
}