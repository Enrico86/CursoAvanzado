using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MarkupExtensions.Extensions;
using CursoAvanzado.Effects;

namespace CursoAvanzado
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Extension.Init();
            MainPage = new Transformaciones();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
