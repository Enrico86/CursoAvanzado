using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoAvanzado.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpAnimations : ContentPage
    {
        public PopUpAnimations()
        {
            InitializeComponent();
            btnPagar.Clicked += BtnPagar_Clicked;
            btnAprobar.Clicked += BtnAprobar_Clicked;
        }

        double QuinticEasing(double t, double b, double c, double d)
        {
            var ts = (t /= d) * t;
            var tc = ts * t;
            var result = b + c * (-2.01 * tc * ts + 3.01 * ts * ts);
            var mapResult = Map(result, b, b + c, 0, 1);
            Console.WriteLine(mapResult);
            return mapResult;
        }

        double Map(double x, double in_min, double in_max, double out_min, double out_max)
        {
            return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
        }
        private async void BtnAprobar_Clicked(object sender, EventArgs e)
        {

            var opacidadInicialFrame = frame.Opacity;
            Func<double, double> quinticEasingFrameOpacity = t => QuinticEasing(t, opacidadInicialFrame, 0 - opacidadInicialFrame, 1);

            var scaleInicial = frame.Scale;
            Func<double, double> quinticEasingScale = t => QuinticEasing(t, scaleInicial, 0 - scaleInicial, 1);

            var opacidadInicialMainContainer = mainContainer.Opacity;
            Func<double, double> quinticEasingContainerOpacity = t => QuinticEasing(t, opacidadInicialMainContainer, 1 - opacidadInicialMainContainer, 1);

            await Task.WhenAll
                (
                frame.ScaleTo(2,1000,Easing.SpringOut),
                frame.FadeTo(0,1000,Easing.CubicInOut)
                );
            await frame.ScaleTo(0, 500, Easing.Linear);
            mainContainer.FadeTo(1, 1500, quinticEasingContainerOpacity);
            mainContainer.IsEnabled = true;
        }

        private async void BtnPagar_Clicked(object sender, EventArgs e)
        {
            mainContainer.IsEnabled = false;
            mainContainer.Opacity = 0.2;

            var opacidadInicial = frame.Opacity;
            Func<double, double> quinticEasingOpacity = t => QuinticEasing(t, opacidadInicial, 1 - opacidadInicial, 1);

            var scaleInicial = frame.Scale;
            Func<double, double> quinticEasingScale = t => QuinticEasing(t, scaleInicial, 1 - scaleInicial, 1);

            await Task.WhenAll
                (
                frame.ScaleTo(2.5,2000,quinticEasingScale),
                frame.FadeTo(1, 2000, quinticEasingOpacity)
                );
            await frame.ScaleTo(1, 1000, Easing.SpringIn);
        }
    }
}