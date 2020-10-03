using CursoAvanzado.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoAvanzado.Views.DataTemplateSelector.ViewCells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PremiumAdViewCell : ViewCell
    {
        public PremiumAdViewCell()
        {
            InitializeComponent();
            this.BindingContext = AdsManager.Instance.Value.Ads;
        }
    }
}