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
    public partial class MarkupExtensions : ContentPage
    {
        public MarkupExtensions()
        {
            InitializeComponent();
            lblTexto.Margin = new Thickness(5, 10, 0, 5);
            lblTexto2.WidthRequest = 200;
            lblTexto2.Margin = new Thickness(this.WidthRequest / 2);
            lblTexto3.Margin = new Thickness(new double[8] 
            {
                20,2,3,4,5,6,7,8
            }.First());
            //lblTexto4.FontAttributes = FontAttributes.Bold;
            //lblTexto4.TextColor = Color.Azure;

        }
    }
}