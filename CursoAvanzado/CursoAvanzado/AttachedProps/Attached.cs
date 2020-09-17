using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CursoAvanzado.AttachedProps
{
    public class Attached
    {
        public static readonly BindableProperty IsAttachedProperty
            = BindableProperty.CreateAttached(
                "IsAttached",
                typeof(bool),
                typeof(Attached),
                defaultValue: false
                );

        public static bool GetIsAttached(BindableObject view)
        {
            return (bool)view.GetValue(IsAttachedProperty);
        }

        public static void SetIsAttached(BindableObject view, bool value)
        {
            view.SetValue(IsAttachedProperty,value);
        }
    }
}
