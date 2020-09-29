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

[assembly: ExportEffect(typeof(UnderlineEffect),"UnderlineEffect")]
namespace CursoAvanzado.Droid.Effects
{
    public class UnderlineEffect : PlatformEffect
    {
        PaintFlags paintFlags;

        protected override void OnAttached()
        {
            var pfLabel = Control as TextView;
            if (pfLabel == null)
                return;
            paintFlags = pfLabel.PaintFlags;
            pfLabel.PaintFlags = Android.Graphics.PaintFlags.UnderlineText;
        }

        protected override void OnDetached()
        {
            var pfLabel = Control as TextView;
            if (pfLabel == null)
                return;
            pfLabel.PaintFlags = paintFlags;
        }
    }
}