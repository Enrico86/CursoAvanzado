using CursoAvanzado.ViewModels;
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
    public partial class StepperDemo : ContentPage
    {
        public StepperDemo()
        {
            InitializeComponent();
            this.BindingContext = new StepperDemoViewModel();
        }
    }
}