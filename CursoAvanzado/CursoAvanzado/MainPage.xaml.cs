using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CursoAvanzado
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //var pruebaIdiom = Device.Idiom;
            //btnTask.Clicked += BtnTaskClicked;
            //var sizeButton = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            //var sizeLabel = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
            //btnTask.FontSize = sizeButton;
            //statusLabel.FontSize = sizeLabel;
            //statusLabel.FontSize = Device.OnPlatform(25,15,35);

            //Device.OnPlatform
            //    (
            //    iOS: () => btnTask.Clicked += (sender, e) =>
            //      {
            //          DisplayAlert("iOS", "Prueba iOS", "OK");
            //      },
            //    Android: ()=>btnTask.Clicked+= (sender, e) =>
            //      {
            //          DisplayAlert("Android", "Prueba Android", "OK");
            //      },
            //    WinPhone:()=>btnTask.Clicked+=(sender,e)=>
            //      {
            //          DisplayAlert("WinPhone", "Prueba WinPhone", "OK");
            //      }
            //    );
            int size;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    size = 25;
                    break;
                case Device.Android:
                    size = 15;
                    break;
                case Device.UWP:
                    size = 35;
                    break;
                default:
                    size = 0;
                    break;
            }
            btnTask.FontSize = size;

            btnTask.Clicked += (sender,e)=>
                {
                    switch (Device.RuntimePlatform)
                    {
                        case Device.iOS:
                            if (Device.Idiom == TargetIdiom.Phone) 
                            { 
                                DisplayAlert("iOS", "Estoy en un móvil con sistema operativo iOS", "OK");
                            }
                            else if (Device.Idiom==TargetIdiom.Tablet)
                            {
                                DisplayAlert("iOS", "Estoy en una tablet con sistema operativo iOS", "OK");
                            }
                            else
                            {
                                DisplayAlert("iOS", "Estoy en otro dispositivo iOS", "OK");
                            }
                            break;
                        case Device.Android:
                            if (Device.Idiom == TargetIdiom.Phone)
                            {
                                DisplayAlert("Android", "Estoy en un móvil con sistema operativo Android", "OK");
                            }
                            else if (Device.Idiom == TargetIdiom.Tablet)
                            {
                                DisplayAlert("Android", "Estoy en una tablet con sistema operativo Android", "OK");
                            }
                            else
                            {
                                DisplayAlert("Android", "Estoy en otro dispositivo Android", "OK");
                            }
                            break;
                        case Device.UWP:
                            DisplayAlert("WinPhone", "Prueba WinPhone", "OK");
                            break;
                        default:
                            DisplayAlert("Error","No se ha estableciudo ningun mensaje para este dispositivo","OK");
                            break;
                    }
                };
        }

        private async void BtnTaskClicked(object sender, EventArgs e)
        {
            await WaitTime(3000).ContinueWith((args) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    statusLabel.Text = "Operación completada";
                });
            });
        }

        private async Task WaitTime(int time)
        {
            await Task.Delay(time);
        }
    }
}
