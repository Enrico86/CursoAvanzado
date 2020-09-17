using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoAvanzado
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AttachedProperties : ContentPage
    {
        public AttachedProperties()
        {
            InitializeComponent();
            //btnGetValue.Clicked += BtnGetValue_Clicked;
            //btnIsAttached.Clicked += BtnIsAttached_Clicked;

        }

        //private void BtnIsAttached_Clicked(object sender, EventArgs e)
        //{
        //    if(OlderAttached.GetIsForOlderPeople(lblMainText))
        //    {
        //        lblMainText.FontSize *= 2;
        //    }
        //}

        //private void BtnGetValue_Clicked(object sender, EventArgs e)
        //{
        //    if (Attached.GetIsAttached(lblAttachedTest))
        //    {
        //        DisplayAlert("Attached", "Property is attached", "OK");
        //    }
        //    else DisplayAlert("Not Attached", "Property is no attached", "OK");
        //}
    }
}