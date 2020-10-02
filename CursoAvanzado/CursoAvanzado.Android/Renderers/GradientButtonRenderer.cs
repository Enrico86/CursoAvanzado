using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CursoAvanzado.Controles;
using CursoAvanzado.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(GradientButton),typeof(GradientButtonRenderer))]
namespace CursoAvanzado.Droid.Renderers
{
    public class GradientButtonRenderer: ButtonRenderer
    {
        public GradientButtonRenderer(Context context): base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {

            }
            if (e.OldElement != null)
            {

            }
            if (e.NewElement != null)
            {
                var button = Control;
                var xButton = e.NewElement;
                var colorTop = Element.BackgroundColor;
                //var colorBottom = Color.Black;
                var colorBottom = Controles.GradientButton.GetColorBottom(xButton);
                button.SetBackground(GetGradientDrawable(colorTop, colorBottom));

            }

        }

        GradientDrawable GetGradientDrawable (Color colorTop, Color colorBottom)
        {
            return new GradientDrawable(GradientDrawable.Orientation.TopBottom,
                new int[] 
                { 
                    colorTop.ToAndroid(), colorBottom.ToAndroid()
                });
        }

    }
}