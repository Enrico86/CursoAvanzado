using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CursoAvanzado.iOS.Effects;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(UnderlineEffect), "UnderlineEffect")]
namespace CursoAvanzado.iOS.Effects
{
    public class UnderlineEffect : PlatformEffect
    {
        NSMutableAttributedString attString;
        protected override void OnAttached()
        {
            var pfLabel = Control as UILabel;
            if (pfLabel == null)
                return;
            attString = new NSMutableAttributedString(pfLabel.Text);
            attString.AddAttribute                
                (UIStringAttributeKey.UnderlineStyle, 
                NSNumber.FromInt32((int)NSUnderlineStyle.Single), 
                new NSRange(0, attString.Length));
            pfLabel.AttributedText = attString;
        }

        protected override void OnDetached()
        {
            var pfLabel = Control as UILabel;
            if (pfLabel == null)
                return;
            attString.RemoveAttribute(pfLabel.Text, new NSRange(0, attString.Length));
            pfLabel.AttributedText = attString;
        }
    }
}