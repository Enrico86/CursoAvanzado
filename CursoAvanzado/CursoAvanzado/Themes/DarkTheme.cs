using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Text;
using System.Linq.Expressions;

namespace CursoAvanzado.Themes
{
    static class DarkTheme
    {
        public static Color BackgroundColor = Color.Black;
        public static Color FontColor = Color.White;
        public static double ParagraphSize = 15;
        public static double TitleSize = ParagraphSize + 5;
        public const FontAttributes QuoteStyle = FontAttributes.Italic;
        public const FontAttributes TitleStyle = FontAttributes.Bold;
    }
}
