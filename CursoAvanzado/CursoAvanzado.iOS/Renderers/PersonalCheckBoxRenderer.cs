using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using CursoAvanzado.Controles;
using CursoAvanzado.iOS.Renderers;
using Foundation;
using SaturdayMP.XPlugins.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms.Xaml;

[assembly: ExportRenderer(typeof(PersonalCheckBox),typeof(PersonalCheckBoxRenderer))]
namespace CursoAvanzado.iOS.Renderers
{

    public class PersonalCheckBoxRenderer : ViewRenderer<PersonalCheckBox, BEMCheckBox>
    {
        private BEMCheckBox nativeCheckBox;
        protected override void OnElementChanged(ElementChangedEventArgs<PersonalCheckBox> e)
        {
            if (e.NewElement != null)
            {
                var xamarinElement = e.NewElement;
                base.OnElementChanged(e);
                nativeCheckBox = new BEMCheckBox(new CGRect(140, 40, 25, 25));
                nativeCheckBox.BoxType = BEMBoxType.Square;

                CheckBoxPropertyChanged(xamarinElement, null);

                xamarinElement.PropertyChanged += XamarinElement_PropertyChanged;

                nativeCheckBox.ValueChanged += (sender, args) =>
                {
                    xamarinElement.IsChecked = nativeCheckBox.On;
                };

                SetNativeControl(nativeCheckBox);
            }

        }

        private void XamarinElement_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (nativeCheckBox != null)
            {
                CheckBoxPropertyChanged((PersonalCheckBox)sender, e.PropertyName);
            }
        }

        private void CheckBoxPropertyChanged(PersonalCheckBox model, string propertyName)
        {
            if (propertyName == null || propertyName == PersonalCheckBox.IsCheckedProperty.PropertyName)
            {
                nativeCheckBox.On = model.IsChecked;
            }

        }
    }
}