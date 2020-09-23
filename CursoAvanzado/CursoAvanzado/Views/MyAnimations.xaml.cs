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
    public partial class MyAnimations : ContentPage
    {
        public MyAnimations()
        {
            InitializeComponent();
        }
        void SetIsEnabledButtonState(bool startButtonState, bool cancelButtonState, bool pauseButtonState)
        {
            startButton.IsEnabled = startButtonState;
            cancelButton.IsEnabled = cancelButtonState;
            pauseButton.IsEnabled = pauseButtonState;
        }

        double originalTranslationX;
        double originalTranslationY;
        double originalRotation;
        double originalRotationX;
        double originalRotationY;
        double originalScale;
        double originalScaleX;
        double originalScaleY;
        double originalOpacity;

        void CatchElementTransfProperties(VisualElement element)
        {
            originalTranslationX = element.TranslationX;
            originalTranslationY = element.TranslationY;
            originalRotation = element.Rotation;
            originalRotationX=element.RotationX;
            originalRotationY=element.RotationY;
            originalScale=element.Scale;
            originalScaleX=element.ScaleX;
            originalScaleY=element.ScaleY;
            originalOpacity = element.Opacity;
        }

        void BackToOriginalElement(VisualElement element)
        {
            element.Rotation = originalRotation;
            element.RotationX = originalRotationX;
            element.RotationY = originalRotationY;
            element.Scale = originalScale;
            element.ScaleX = originalScaleX;
            element.ScaleY = originalScaleY;
            element.TranslationX = originalTranslationX;
            element.TranslationY = originalTranslationY;
            element.Opacity = originalOpacity;
        }



        private async void OnStartAnimationButtonClicked(object sender, EventArgs e)
        {
            CatchElementTransfProperties(image);
            SetIsEnabledButtonState(false, true, true);
            //simple animation
            //var animation = new Animation(v => image.Scale = v, 1, 2);
            //animation.Commit(this, "simpleAnimation", 16, 2000, 
            //    Easing.Linear, (v, c) => image.Scale = 1, () => true);

            var parentAnimation = new Animation();
            var scaleUpAnimation = new Animation(v => image.Scale = v, 1, 2, Easing.SinIn);
            var rotateAnimation = new Animation(v => image.Rotation = v, 0, 360, Easing.CubicIn);
            var reRotateAnimation = new Animation(v => image.Rotation = v, 360, 0, Easing.CubicOut);
            var scaleDownAnimation = new Animation(v => image.Scale = v, 2, 1, Easing.SinOut);

            parentAnimation.Add(0, 0.5, scaleUpAnimation);
            parentAnimation.Add(0.5, 1, scaleDownAnimation);
            parentAnimation.Add(0, 0.5, rotateAnimation);
            parentAnimation.Add(0.5, 1, reRotateAnimation);

            parentAnimation.Commit(this, "ChildAnimation", 16, 4000, null,
                (v, c) =>
                {
                    SetIsEnabledButtonState(true, false, false);
                });
            
        }

        private void OnCancelAnimationButtonClicked(object sender, EventArgs e)
        {
            this.AbortAnimation("ChildAnimation");
            BackToOriginalElement(image);
            SetIsEnabledButtonState(true, false, false);
        }

        private void OnPauseAnimationButtonClicked(object sender, EventArgs e)
        {
            this.AbortAnimation("ChildAnimation");
            SetIsEnabledButtonState(true, false, false);
        }
    }
}