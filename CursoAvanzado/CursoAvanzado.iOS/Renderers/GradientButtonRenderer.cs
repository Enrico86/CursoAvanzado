using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using CoreAnimation;
using CoreGraphics;
using CursoAvanzado.Controles;
using CursoAvanzado.iOS.Renderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(GradientButton),typeof(GradientButtonRenderer))]
namespace CursoAvanzado.iOS.Renderers
{
    public class GradientButtonRenderer: ButtonRenderer
    {
        public override void Draw(CGRect rect)
        {
            base.Draw(rect);
            var button = Control;
            var xButton = e.NewElement;
            var colorTop = Element.BackgroundColor;
            //var colorBottom = Color.Black;
            var colorBottom = Controles.GradientButton.GetColorBottom(xButton);
            var gradLayer = GetGradientLayer(colorTop, colorBottom, (float)Element.Width, (float)Element.Height);
            button.Layer.InsertSublayer(gradLayer, 0);
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
            }
            if (e.OldElement != null)
            {
            }
            if (e.NewElement != null)
            {
            }
        }

        CAGradientLayer GetGradientLayer (Color colorTop, Color colorBottom, nfloat width, nfloat height)
        {
            var gradLayer = new CAGradientLayer();
            gradLayer.Frame = new CoreGraphics.CGRect(0, 0, width, height);
            gradLayer.Colors = new CGColor[] { colorTop.ToCGColor(), colorBottom.ToCGColor() };
            gradLayer.StartPoint = new CGPoint(0, 0);
            gradLayer.EndPoint = new CGPoint(0, 1);
            return gradLayer;
        }
    }
}