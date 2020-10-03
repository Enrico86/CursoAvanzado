using System;
using System.Collections.Generic;
using System.Text;

namespace CursoAvanzado.Models.Ads
{
    public class TextAd: Ad
    {
        private string _text;

        public string Text
        {
            get => _text;
            set => ChangePropertyValue(ref _text, value);
        }
    }
}
