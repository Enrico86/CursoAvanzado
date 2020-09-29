using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using CursoAvanzado.iOS.Effects;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(SelectAllEffect),"SelectAllEffect")]
namespace CursoAvanzado.iOS.Effects
{
    public class SelectAllEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            if (args.PropertyName==VisualElement.IsFocusedProperty.PropertyName)
            {
                var pfEntry = Control as UITextField;
                if (pfEntry == null)
                    return;
                pfEntry.PerformSelector
                    (new ObjCRuntime.Selector("SelectAll"), null, 0.0f);
            }
        }
    }
}