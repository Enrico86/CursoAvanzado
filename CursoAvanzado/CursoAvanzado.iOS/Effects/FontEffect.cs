using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CursoAvanzado.iOS.Effects;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(FontEffect), "FontEffect")]
namespace CursoAvanzado.iOS.Effects
{
    public class FontEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var xLabel = Element as Label;
            if (xLabel == null)
                return;
            var pLabel = Control as UILabel;
            if (pLabel == null)
                return;
            var fontFamily = Views.Effects.FontEffect.GetFontName(xLabel);

            pLabel.Font = UIFont.FromName($"{fontFamily}", pLabel.Font.PointSize);
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}