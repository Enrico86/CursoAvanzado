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

[assembly:ResolutionGroupName("EN")]
[assembly: ExportEffect(typeof(SimpleSliderEffect),"SimpleSliderEffect")]
namespace CursoAvanzado.Droid.Effects
{
    public class SimpleSliderEffect : PlatformEffect
    {
        ColorFilter color;
      

        protected override void OnAttached()
        {
            var xfSlider = Element as Xamarin.Forms.Slider;
            if (xfSlider == null)
                return;
            var pfSlider = Control as Android.Widget.SeekBar;
            if (pfSlider == null)
                return;

            color = pfSlider.ProgressDrawable.ColorFilter;
            pfSlider.ProgressDrawable.SetColorFilter
                (new PorterDuffColorFilter(Xamarin.Forms.Color.DarkGreen.ToAndroid(), 
                PorterDuff.Mode.SrcIn));
            
        }
          
        protected override void OnDetached()
        {
            var pfSlider = Control as Android.Widget.SeekBar;
            if (pfSlider == null)
                return;
            pfSlider.ProgressDrawable.SetColorFilter(color);
        }
    }
}