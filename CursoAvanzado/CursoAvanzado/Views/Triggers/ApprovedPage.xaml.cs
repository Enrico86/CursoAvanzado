using CursoAvanzado.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoAvanzado.Views.Triggers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApprovedPage : ContentPage
    {
        public ApprovedPage()
        {
            InitializeComponent();
            this.BindingContext = new ApprovedPageViewModel();
        }
    }
}