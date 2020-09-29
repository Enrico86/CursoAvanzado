using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CursoAvanzado.iOS.Effects;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(SimpleSliderEffect), "SimpleSliderEffect")]
namespace CursoAvanzado.iOS.Effects
{
    public class SimpleSliderEffect : PlatformEffect
    {
        UIColor minColor;
        UIColor maxColor;

        protected override void OnAttached()
        {
            var xfSlider = Element as Xamarin.Forms.Slider;
            if (xfSlider == null)
                return;
            var pfSlider = Control as UISlider;
            if (pfSlider == null)
                return;

            minColor = pfSlider.MinimumTrackTintColor;
            maxColor = pfSlider.MaximumTrackTintColor;

            pfSlider.MinimumTrackTintColor = UIColor.Green;
            pfSlider.MaximumTrackTintColor = UIColor.Green;
        }

        protected override void OnDetached()
        {
            var pfSlider = Control as UISlider;
            if (pfSlider == null)
                return;
            pfSlider.MinimumTrackTintColor = minColor;
            pfSlider.MaximumTrackTintColor = maxColor;
        }
    }
}