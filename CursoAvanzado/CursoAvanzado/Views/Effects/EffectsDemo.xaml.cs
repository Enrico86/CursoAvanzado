using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace CursoAvanzado.Views.Effects
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EffectsDemo : ContentPage
    {
        RoutingEffect sliderEffect;
        //Effect sliderEffect2;

        public EffectsDemo()
        {
            InitializeComponent();
            sliderEffect = new SliderEffect();
            mySlider.Effects.Add(sliderEffect);

            //sliderEffect2 = Effect.Resolve("EN.SimpleSliderEffect");
            //mySlider2.Effects.Add(sliderEffect2);
        }

        private void switchEffect_Toggled(object sender, ToggledEventArgs e)
        {
            mySlider.Effects.Remove(sliderEffect);
            if (switchEffect.IsToggled)
            {
                mySlider.Effects.Add(sliderEffect);
            }

            //mySlider2.Effects.Remove(sliderEffect2);
            //if (switchEffect.IsToggled)
            //{
            //    mySlider2.Effects.Add(sliderEffect2);
            //}
        }
    }
}