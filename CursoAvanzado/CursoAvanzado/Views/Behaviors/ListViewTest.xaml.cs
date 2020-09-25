using CursoAvanzado.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoAvanzado.Views.Behaviors
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewTest : ContentPage
    {
        public ListViewTest()
        {
            InitializeComponent();
            this.BindingContext = new ListViewTestViewModel();
        }
    }
}