﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CursoAvanzado.Controles;
using CursoAvanzado.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyEntry),typeof(MyEntryRenderer))]
namespace CursoAvanzado.Droid.Renderers
{
    public class MyEntryRenderer: EntryRenderer
    {
        public MyEntryRenderer(Context context): base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control!=null)
            {
                Control.SetBackgroundColor(Color.LightSkyBlue.ToAndroid());
            }
        }
    }
}