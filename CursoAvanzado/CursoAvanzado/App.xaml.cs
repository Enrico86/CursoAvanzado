using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MarkupExtensions.Extensions;
using CursoAvanzado.Effects;
using CursoAvanzado.Views;
using CursoAvanzado.Views.Triggers;
using CursoAvanzado.Views.Behaviors;
using CursoAvanzado.Views.Effects;
using CursoAvanzado.Views.CustomRenderers;
using CursoAvanzado.Views.DataTemplateSelector;

namespace CursoAvanzado
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Extension.Init();
            MainPage = new DataTemplateSelectorPage();
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
