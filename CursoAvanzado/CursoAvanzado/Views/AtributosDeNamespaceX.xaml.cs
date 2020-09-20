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
    public partial class AtributosDeNamespaceX : ContentPage
    {
        public AtributosDeNamespaceX()
        {
            InitializeComponent();
            Color myColor = new Color(.23, .89, .45);
            box.Color = myColor;
        }
    }
}