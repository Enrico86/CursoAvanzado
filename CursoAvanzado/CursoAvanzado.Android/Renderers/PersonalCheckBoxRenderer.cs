using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CursoAvanzado.Controles;
using CursoAvanzado.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(PersonalCheckBox),typeof(PersonalCheckBoxRenderer))]
namespace CursoAvanzado.Droid.Renderers
{
    public class PersonalCheckBoxRenderer: ViewRenderer<PersonalCheckBox, Android.Widget.CheckBox>
    {
        private Android.Widget.CheckBox nativeCheckBox;
        public PersonalCheckBoxRenderer(Context context): base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<PersonalCheckBox> e)
        {
            if (e.NewElement!=null)
            {
                var xamarinElement = e.NewElement;
                base.OnElementChanged(e);
                nativeCheckBox = new Android.Widget.CheckBox(Context);
                CheckBoxPropertyChanged(xamarinElement, null);

                xamarinElement.PropertyChanged += XamarinElement_PropertyChanged;
                nativeCheckBox.CheckedChange += (sender, e2) =>
                  {
                      xamarinElement.IsChecked = e2.IsChecked;
                  };


                SetNativeControl(nativeCheckBox);
            }

        }

        private void XamarinElement_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (nativeCheckBox!=null)
            {
                CheckBoxPropertyChanged((PersonalCheckBox)sender, e.PropertyName);
            }
        }

        private void CheckBoxPropertyChanged(PersonalCheckBox model, string propertyName)
        {
            if (propertyName==null||propertyName==PersonalCheckBox.IsCheckedProperty.PropertyName)
            {
                nativeCheckBox.Checked = model.IsChecked;
            }
        }
    }
}