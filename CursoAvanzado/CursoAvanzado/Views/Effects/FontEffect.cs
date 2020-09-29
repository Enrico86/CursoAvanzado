using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CursoAvanzado.Views.Effects
{
    public class FontEffect: RoutingEffect
    {
        public static readonly BindableProperty FontNameProperty = BindableProperty.CreateAttached(
            "FontName",
            typeof(string),
            typeof(FontEffect),
            null);

        public static void SetFontName(VisualElement view, string fontName)
        {
            view.SetValue(FontNameProperty, fontName);
        }

        public static string GetFontName (VisualElement view)
        {
            return (string)view.GetValue(FontNameProperty);
        }

        public FontEffect(): base("EN.FontEffect")
        {
        }
    }
}
