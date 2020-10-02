using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CursoAvanzado.Controles
{
    public class GradientButton: Button
    {
        public static readonly BindableProperty ColorBottomProperty =
            BindableProperty.CreateAttached("ColorBottom", typeof(Color), typeof(GradientButton), null);

        public static Color GetColorBottom (VisualElement view)
        {
            return (Color)view.GetValue(ColorBottomProperty);
        }
        
        public static void SetColorBottom(VisualElement view, Color color)
        {
            view.SetValue(ColorBottomProperty, color);
        }

    }
}
