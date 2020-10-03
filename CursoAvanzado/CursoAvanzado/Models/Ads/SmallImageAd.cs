using System;
using System.Collections.Generic;
using System.Text;

namespace CursoAvanzado.Models.Ads
{
    public class SmallImageAd: Ad
    {
        private string _text;

        public string Text
        {
            get => _text;
            set => ChangePropertyValue(ref _text, value);
        }

        private string _imageUrl1;

        public string ImageUrl1
        {
            get => _imageUrl1;
            set => ChangePropertyValue(ref _imageUrl1, value);
        }

    }
}
