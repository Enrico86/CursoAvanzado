using CursoAvanzado.Controles;
using CursoAvanzado.Models;
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
    public partial class BindableProperties : ContentPage
    {
        public BindableProperties()
        {
            InitializeComponent();
            this.BindingContext = new WebSite()
            {
                WebTitle = "Blog de Enrico",
                WebSubTitle = "Sitio dedicado a Xamarin"
            };
            //lblBindings.Text = "PRUEBA BINDINGS";
            //BindingContext = new Person()
            //{
            //    Name = "Enrico",
            //    HealthScore = 8.9
            //};
        }
    }
}