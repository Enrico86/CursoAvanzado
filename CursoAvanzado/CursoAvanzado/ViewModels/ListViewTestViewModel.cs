using CursoAvanzado.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CursoAvanzado.ViewModels
{
    public class ListViewTestViewModel
    {
        public List<Person> People { get; set; }
        public ICommand SelectedItemCommand { get; set; }
        public ICommand AcceptCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public ListViewTestViewModel()
        {
            People = new List<Person>
                {
                    new Person
                    {
                        Name="Enrico"
                    },
                    new Person
                    {
                        Name="Anais"
                    },
                    new Person
                    {
                        Name="Angelo"
                    },
                    new Person
                    {
                        Name="Lise"
                    },
                    new Person
                    {
                        Name="Alessandro"
                    }
                };
            SelectedItemCommand = new Command(async (item) =>
            {
                var person = item as Person;
                var name = person.Name;
                await ShowData(name);
            });
            AcceptCommand = new Command(() =>
              {
                  Debug.WriteLine("Aceptado Display Alert");
              });
            CancelCommand = new Command(() =>
              {
                  Debug.WriteLine("Cancelado Display Alert");
              });


        }

        private async Task ShowData(string name)
        {
            await App.Current.MainPage.DisplayAlert("Nombre",name,"OK");
        }
    }
}
