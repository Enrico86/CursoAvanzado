using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CursoAvanzado.Controles
{
    public class PersonalCheckBox:View
    {
        public event EventHandler Checked;
        protected virtual void OnChecked(EventArgs e)
        {
            if (Checked!=null)
            {
                Checked(this, e);
            }
        }

        public static readonly BindableProperty IsCheckedProperty
            = BindableProperty.Create("IsChecked",
                typeof(bool),
                typeof(PersonalCheckBox),
                false,
                propertyChanged:(bindable,oldValue,newValue)=>
                {
                    (bindable as PersonalCheckBox).OnChecked(new EventArgs());
                });
        public bool IsChecked
        {
            get 
            { 
                return (bool)GetValue(IsCheckedProperty); 
            }
            set 
            { 
                SetValue(IsCheckedProperty, value); 
            }
        }


    }
}
