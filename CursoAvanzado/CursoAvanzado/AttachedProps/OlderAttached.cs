using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CursoAvanzado.AttachedProps
{
    public class OlderAttached
    {
        public static readonly BindableProperty IsForOlderPeopleProperty = BindableProperty.CreateAttached
            (
            "IsForOlderPeople",
            typeof(bool),
            typeof(OlderAttached),
            defaultValue: false,
            propertyChanged: OnValueChanged
            );

        private static void OnValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable as Label !=null)
            {
                var control = bindable as Label;
                control.FontSize *= 2; 
            }
            else if (bindable as Entry != null)
            {
                var control = bindable as Entry;
                control.FontSize /= 2;
            }
            return;
        }

        public static bool GetIsForOlderPeople (BindableObject view)
        {
            return (bool)view.GetValue(IsForOlderPeopleProperty);
        }

        public static void SetIsForOlderPeople (BindableObject view, bool value)
        {
            view.SetValue(IsForOlderPeopleProperty, value);
        }

    }
}
