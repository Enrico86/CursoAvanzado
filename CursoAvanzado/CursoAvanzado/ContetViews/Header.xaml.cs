using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoAvanzado.ContetViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Header : ContentView
    {
        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(
                "Title",
                typeof(string),
                typeof(Header),
                defaultValue: "Título",
                BindingMode.Default,
                propertyChanged: TitleChanged);

        private static void TitleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = bindable as Header;
            if (instance != null)
            {
                instance.lblTitle.Text = newValue.ToString();
            }
        }

        public string Title
        {
            get
            {
                return GetValue(TitleProperty).ToString();
            }

            set
            {
                SetValue(TitleProperty, value);
            }
        }


        public static readonly BindableProperty SubTitleProperty =
            BindableProperty.Create(
                "SubTitle",
                typeof(string),
                typeof(Header),
                defaultValue: "SubTítulo",
                propertyChanged: SubTitleChanged
                );

        private static void SubTitleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = bindable as Header;
            instance.lblSubTitle.Text = (string)newValue;
        }

        public string SubTitle
        {
            get
            {
                return (string)GetValue(SubTitleProperty);
            }

            set
            {
                SetValue(SubTitleProperty, value);
            }
        }





        public Header()
        {
            InitializeComponent();

        }
    }
}