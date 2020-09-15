using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CursoAvanzado.Controles
{
    public class HealthBox : BoxView
    {
        public static readonly BindableProperty HealthStatusProperty =
            BindableProperty.Create(
                "HealthStatus",
                typeof(double),
                typeof(HealthBox),
                10.0,
                BindingMode.Default,
                propertyChanged:ValueChanged);

        private static void ValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = bindable as HealthBox;
            if (instance!=null)
            {
                instance.SetHealth((double)newValue);
            }

        }
        void SetHealth(double health)
        {
            if (health < 4)
            {
                Color = Color.DarkRed;
            }
            else if (health < 7)
            {
                Color = Color.Yellow;
            }
            else
            {
                Color = Color.DarkGreen;
            }
        }

        public HealthBox()
        {
            SetHealth((double)HealthStatusProperty.DefaultValue);
        }
        public double HealthStatus
        {
            get
            {
                return (double)GetValue(HealthStatusProperty);
            }
            set
            {
                SetValue(HealthStatusProperty, value);
            }
        }



    }
}
