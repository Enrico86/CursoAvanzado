using CursoAvanzado.Models.Ads;
using CursoAvanzado.Views.DataTemplateSelector.ViewCells;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CursoAvanzado.Selectors
{
    public class AdsTemplateSelector : DataTemplateSelector
    {
        private DataTemplate textTemplate;
        private DataTemplate smallImageTemplate;
        private DataTemplate premiumTemplate;

        public AdsTemplateSelector()
        {
            textTemplate = new DataTemplate(typeof(TextAdViewCell));
            smallImageTemplate = new DataTemplate(typeof(SmallImageAdViewCell));
            premiumTemplate = new DataTemplate(typeof(PremiumAdViewCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is TextAd)
            {
                return textTemplate;
            }
            if (item is SmallImageAd)
            {
                return smallImageTemplate;
            }
            if (item is PremiumAd)
            {
                return premiumTemplate;
            }
            else throw new Exception("Ad desconocido");
        }
    }
}
