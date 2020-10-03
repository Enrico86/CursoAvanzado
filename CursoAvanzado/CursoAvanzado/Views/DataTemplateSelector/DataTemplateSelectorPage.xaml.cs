using CursoAvanzado.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoAvanzado.Views.DataTemplateSelector
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataTemplateSelectorPage : ContentPage
    {
        public DataTemplateSelectorPage()
        {
            InitializeComponent();
            this.BindingContext = AdsManager.Instance.Value.Ads;
        }
    }
}