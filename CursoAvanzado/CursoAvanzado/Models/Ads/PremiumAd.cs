using System;
using System.Collections.Generic;
using System.Text;

namespace CursoAvanzado.Models.Ads
{
    public class PremiumAd: Ad
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

        private string _imageUrl2;

        public string ImageUrl2
        {
            get => _imageUrl2;
            set => ChangePropertyValue(ref _imageUrl2, value);
        }

        private string _imageUrl3;

        public string ImageUrl3
        {
            get => _imageUrl3;
            set => ChangePropertyValue(ref _imageUrl3, value);
        }

    }
}
