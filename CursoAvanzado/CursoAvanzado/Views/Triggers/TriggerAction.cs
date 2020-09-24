using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CursoAvanzado.Views.Triggers
{
    public class ScaleAction : TriggerAction<VisualElement>
    {
        public Point Anchor { get; set; }
        public double Scale { get; set; }
        public int Lenght { get; set; }

        [TypeConverter(typeof(EasingConverter))]
        public Easing EasingType { get; set; }


        public ScaleAction()
        {
            Anchor = new Point(0.5, 0.5);
            Scale = 1;
            Lenght = 250;
            EasingType = Easing.Linear;
        }
        protected override void Invoke(VisualElement sender)
        {
            sender.AnchorX=Anchor.X;
            sender.AnchorY = Anchor.Y;
            sender.ScaleTo(Scale, (uint)Lenght, EasingType);
        }
    }

    //public class DeScaleAction : TriggerAction<VisualElement>
    //{
    //    protected override void Invoke(VisualElement sender)
    //    {
    //        sender.ScaleTo(1,1000);
    //    }
    //}
}
