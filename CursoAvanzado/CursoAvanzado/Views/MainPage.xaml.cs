using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
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
            btnTask2.Clicked += BtnTask2Clicked;

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
                    size = 45;
                    break;
                case Device.UWP:
                    size = 35;
                    break;
                default:
                    size = 0;
                    break;
            }
            btnTask4.FontSize = size;

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
                            if (Device.Idiom == TargetIdiom.Phone)
                            {
                                DisplayAlert("WinPhone", "Estoy en un móvil con sistema operativo WinPhone", "OK");
                            }
                            else if (Device.Idiom == TargetIdiom.Tablet)
                            {
                                DisplayAlert("WinPhone", "Estoy en una tablet con sistema operativo WinPhone", "OK");
                            }
                            else
                            {
                                DisplayAlert("WinPhone", "Estoy en otro dispositivo WinPhone", "OK");
                            }
                            break;
                        default:
                            DisplayAlert("Error","No se ha establecido ningun mensaje para este dispositivo","OK");
                            break;
                    }
            };

            btnTask3.Clicked += BtnTask3_Clicked;
            btnTask5.Clicked += BtnTask5_Clicked;
            btnTask6.Clicked += BtnTask6_Clicked;
        }

        private void BtnTask6_Clicked(object sender, EventArgs e)
        {
            stylesLabel.Style = Device.Styles.TitleStyle;
        }

        private void BtnTask5_Clicked(object sender, EventArgs e)
        {
            int contador=0;
            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
              {
              while (contador<5)
                  {
                      DisplayAlert("Tiempo", $"Ha pasado {++contador} segundo/s", "OK");
                      return true;
                  }
                  return false;
              });
        }

        private void BtnTask3_Clicked(object sender, EventArgs e)
        {
            //Device.OpenUri(new Uri("https://www.gazzetta.it"));
            Launcher.OpenAsync("https://www.gazzetta.it");
        }

        private async void BtnTask2Clicked(object sender, EventArgs e)
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
