using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CursoAvanzado.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportEffect(typeof(SelectAllEffect), "SelectAllEffect")]
namespace CursoAvanzado.Droid.Effects
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
            if (args.PropertyName=="IsFocused")
            {
                var pfEntry = Control as EditText;
                if (pfEntry == null)
                    return;
                pfEntry.SetSelectAllOnFocus(true);
            }
        }
    }
}