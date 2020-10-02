using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AudioUnit;
using CursoAvanzado.Controles;
using CursoAvanzado.iOS.Renderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyEntry),typeof(MyEntryRenderer))]
namespace CursoAvanzado.iOS.Renderers
{
    public class MyEntryRenderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if(Control != null)
            {
                Control.BackgroundColor = UIColor.FromRGB(135, 206, 250);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}