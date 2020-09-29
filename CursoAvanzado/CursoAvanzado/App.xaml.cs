﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MarkupExtensions.Extensions;
using CursoAvanzado.Effects;
using CursoAvanzado.Views;
using CursoAvanzado.Views.Triggers;
using CursoAvanzado.Views.Behaviors;
using CursoAvanzado.Views.Effects;

namespace CursoAvanzado
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Extension.Init();
            MainPage = new EffectsDemo();
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
