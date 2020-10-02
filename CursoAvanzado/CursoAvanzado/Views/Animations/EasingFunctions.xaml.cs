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
    public partial class EasingFunctions : ContentPage
    {
        public EasingFunctions()
        {
            InitializeComponent();
            btnEasing.Clicked += BtnEasing_Clicked;
        }

        private async void BtnEasing_Clicked(object sender, EventArgs e)
        {
            ///Easing Functions XamarinForms
            //await btnEasing.TranslateTo(200, 500, 2000, Easing.SinIn);
            //await Task.Delay(1000);
            //await btnEasing.TranslateTo(0, 0, 2000, Easing.SinOut);
            //await Task.Delay(1000);
            //await btnEasing.TranslateTo(200, 500, 2000, Easing.SinInOut);
            //await Task.Delay(1000);
            //await btnEasing.TranslateTo(0, 0, 2000, Easing.CubicIn);
            //await Task.Delay(1000);
            //await btnEasing.TranslateTo(200, 500, 2000, Easing.CubicOut);
            //await Task.Delay(1000);
            //await btnEasing.TranslateTo(0, 0, 2000, Easing.CubicInOut);
            //await Task.Delay(1000);
            //await btnEasing.TranslateTo(200, 500, 2000, Easing.BounceIn);
            //await Task.Delay(1000);
            //await btnEasing.TranslateTo(0, 0, 2000, Easing.BounceOut);
            //await Task.Delay(1000);
            //await btnEasing.TranslateTo(200, 500, 2000, Easing.SpringIn);
            //await Task.Delay(1000);
            //await btnEasing.TranslateTo(0, 0, 2000, Easing.SpringOut);

            Func<double, double> linear = t => t;
            Easing easing = new Easing(t => t);

            double Linear (double t)
            {
                Console.WriteLine(t);
                return t;
            }
            Func<double, double> linear2 = t => Linear(t);

            double MyOwnEasing (double t)
            {
                var result = (int)(5 * t) / 5.0;
                Console.WriteLine(result);
                return result;
            }
            Func<double, double> ownFunc = t => MyOwnEasing(t);


            double ElasticEasing (double tiempo, double valorInicial, double cambio, double duracion) 
            {
                var ts = (tiempo /= duracion) * tiempo;
                var tc = ts * tiempo;
                var result = valorInicial + cambio * (33 * tc * ts + -59 * ts * ts + 32 * tc + -5 * ts);
                var mapResult = Map(result, valorInicial, valorInicial + cambio, 0, 1);
                Console.WriteLine(mapResult);
                return mapResult;
            }

            double OwnElasticEasing (double t, double b, double c, double d) 
            {
                var ts = (t /= d) * t;
                var tc = ts * t;
                var result = b + c * (64.2325 * tc * ts + -137.3975 * ts * ts + 97.665 * tc + -26.35 * ts + 2.85 * t);
                var mapResult = Map(result, b, b + c, 0, 1);
                return mapResult;
            }

            double Map (double x, double in_min, double in_max, double out_min, double out_max)
            {
                return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
            }

            var translationY = btnEasing.TranslationY;
            Func<double, double> elasticEasing 
                = t => ElasticEasing(t,translationY,500-translationY,1);

            var translationX = btnEasing.TranslationX;
            Func<double, double> ownElasticEasing =
                t => OwnElasticEasing(t, translationX, 200 - translationX, 1);

            await btnEasing.TranslateTo(200, 500, 5000, ownElasticEasing);

        }
    }
}