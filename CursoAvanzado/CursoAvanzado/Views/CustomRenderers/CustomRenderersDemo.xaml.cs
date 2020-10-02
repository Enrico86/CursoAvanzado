using CursoAvanzado.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoAvanzado.Views.CustomRenderers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomRenderersDemo : ContentPage
    {
        public CustomRenderersDemo()
        {
            InitializeComponent();
            gradientButtonCheckState.Clicked += GradientButtonCheckState_Clicked;
            coolCheckBox.Checked += CoolCheckBox_Checked;
        }

        private void CoolCheckBox_Checked(object sender, EventArgs e)
        {
            DisplayAlert("CheckBox Status", coolCheckBox.IsChecked.ToString(), "OK");
        }

        private void GradientButtonCheckState_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("CheckBoxStatus", coolCheckBox.IsChecked.ToString(), "OK");
        }
    }
}