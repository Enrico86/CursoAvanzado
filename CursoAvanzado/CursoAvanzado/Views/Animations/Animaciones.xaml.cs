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
    public partial class Animaciones : ContentPage
    {
        public Animaciones()
        {
            InitializeComponent();
        }

        void SetIsEnabledButtonState (bool startButtonState, bool cancelButtonState)
        {
            startButton.IsEnabled = startButtonState;
            cancelButton.IsEnabled = cancelButtonState;
        }

        double originalTranslationY;

        void CatchOriginalElement (VisualElement element)
        {
            originalTranslationY = element.TranslationY;
        }

        void BackToOriginalElement (VisualElement element)
        {
            element.Rotation = 0;
            element.RotationX = 0;
            element.RotationY = 0;
            element.Scale = 1;
            element.ScaleX = 1;
            element.ScaleY = 1;
            element.TranslationX = 0;
            element.TranslationY = originalTranslationY;
            element.Opacity = 1;
        }



        private async void OnStartAnimationButtonClicked(object sender, EventArgs e)
        {
            SetIsEnabledButtonState(false, true);
            CatchOriginalElement(image);
            //await image.TranslateTo(100, 100, 1000, Easing.Linear);
            //await image.ScaleTo(1.5, 500, Easing.SinIn);
            //await image.FadeTo(0, 500);
            //await image.FadeTo(1, 250);
            //await image.TranslateTo(150, 50, 1500, Easing.Linear);
            //await image.TranslateTo(-50, -50, 2000, Easing.Linear);
            //await image.TranslateTo(0, 0, 500, Easing.Linear);
            //await image.ScaleTo(0.5, 350);
            //await image.ScaleXTo(-2, 1000);
            //await image.ScaleXTo(1, 500);
            //await image.ScaleYTo(-2,1000);
            //await image.ScaleYTo(1, 500);
            //await image.RotateTo(150, 250);
            //await image.RotateTo(0, 350);
            //await image.ScaleTo(1, 250);
            //await image.RotateXTo(180, 500);
            //await image.RotateYTo(180, 500);
            //await image.RotateXTo(0, 500);
            //await image.RotateYTo(0, 500);4

            //Cada tarea se lleva a cabo una a la vez si no le damos al botón detener

            //var cancelado = await image.TranslateTo(100,50, 2000);
            //if (!cancelado)
            //{
            //    await image.TranslateTo(100,50 , 1000);
            //}
            //cancelado = await image.ScaleTo(1.5, 1000);
            //if (!cancelado)
            //{
            //    await image.ScaleTo(1.5, 1000);
            //}
            //cancelado = await image.FadeTo(0.5, 1000);
            //if (!cancelado)
            //{
            //    await image.FadeTo(0.5, 1000);
            //}

            //Cancelando dos tareas

            //var cancelado = await image.TranslateTo(50, 50, 2000) || await image.ScaleTo(2,1000);
            //if (!cancelado)
            //{
            //    await image.TranslateTo(50, 50, 2000);
            //    await image.ScaleTo(2, 1000);
            //}


            //Multiples animaciones. Empieza el segundo escalado cuando se lleva a cabo una de las tareas del WhenAny
            //await Task.WhenAny<bool>
            //    (
            //    image.RotateTo(360,4000),
            //    image.ScaleTo(2,2000)
            //    );
            //await image.ScaleTo(1, 2000);

            //Multiples animaciones. Empieza el segundo escalado cuando se llevan a cabo todas las tareas del WhenAll
            //await Task.WhenAny<bool>
            //    (
            //    image.RotateTo(360,5000),
            //    image.ScaleTo(2,2000),
            //    image.TranslateTo(50,50,2000)
            //    );
            //image.ScaleTo(1, 3000);
            //image.TranslateTo(0, 0,3000);

            await image.TranslateTo(0, 0,5000, Easing.BounceOut);
        }

        private void OnCancelAnimationButtonClicked(object sender, EventArgs e)
        {
            ViewExtensions.CancelAnimations(image);
            BackToOriginalElement(image);
            SetIsEnabledButtonState(true, false);
        }
    }
}