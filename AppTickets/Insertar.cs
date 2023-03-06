using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Javax.Security.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppTickets
{
    [Activity(Label = "Reparacion")]
    public class Insertar : Activity
    {
        Button btnVolverMenu;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            btnVolverMenu = FindViewById<Button>(Resource.Id.btnVolverMenu);

            btnVolverMenu.Click += BtnVolverMenu_Click;
        }

        private void BtnVolverMenu_Click(object sender, System.EventArgs e)
        {
            //var layout_bienvenido = new Intent(this, typeof(Bienvenido));
            //StartActivity(layout_bienvenido);
            //Finish();

            SetContentView(Resource.Layout.Bienvenido);
        }
        
    }
}