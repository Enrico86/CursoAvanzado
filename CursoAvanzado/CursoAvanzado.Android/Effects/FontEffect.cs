using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CursoAvanzado.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportEffect(typeof(FontEffect),"FontEffect")]
namespace CursoAvanzado.Droid.Effects
{
    public class FontEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var xLabel = Element as Label;
            if (xLabel == null)
                return;
            var pLabel = Control as TextView;
            var fontFamily = CursoAvanzado.Views.Effects.FontEffect.GetFontName(xLabel);

            var font = Typeface.CreateFromAsset(Android.App.Application.Context.Assets, $"SweetHipster.ttf");
            pLabel.Typeface= font;
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}