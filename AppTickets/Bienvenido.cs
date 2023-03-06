using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Toolbar = Android.Widget.Toolbar;

namespace AppTickets
{
    [Activity(Label = "Bienvenido")]
    public class Bienvenido : Activity
    {
        Toolbar toolbarmenu;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Bienvenido);
            toolbarmenu = FindViewById<Toolbar>(Resource.Id.toolbarMenu);
            
            SetActionBar(toolbarmenu);
            ActionBar.Title = "Menu";

        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.Insertar:
                    //Intent insertar_est = new Intent(this, typeof(Insertar));
                    //StartActivity(insertar_est);
                    SetContentView(Resource.Layout.Insertar);
                    break;
                case Resource.Id.Buscar:
                    //Intent buscar_est = new Intent(this, typeof(Buscar));
                    //StartActivity(buscar_est);
                    SetContentView(Resource.Layout.Buscar);
                    break;
                case Resource.Id.Eliminar:
                    //Intent eliminar_est = new Intent(this, typeof(Eliminar));
                    //StartActivity(eliminar_est);
                    SetContentView(Resource.Layout.Eliminar);
                    break;
                case Resource.Id.Modificar:
                    //Intent mod_est = new Intent(this, typeof(Modificar));
                    //StartActivity(mod_est);
                    SetContentView(Resource.Layout.Modificar);
                    break;
                default:
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }

    }
}