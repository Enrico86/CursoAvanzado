using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CursoAvanzado.Models.Ads
{
    public class Ad : INotifyPropertyChanged
    {
        private string _titleAd;

        public string TitleAd
        {
            get => _titleAd;
            set => ChangePropertyValue(ref _titleAd, value);
        }

        private DateTime _publicationDate;

        public DateTime PublicationDate
        {
            get => _publicationDate;
            set => ChangePropertyValue(ref _publicationDate, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected bool ChangePropertyValue<T> (ref T field, T value, [CallerMemberName]string propertyName="")
        {
            if (!Equals(field,value))
            {
                field = value;
                OnPropertyChanged(propertyName);
                return true;
            }
            return false;
        }

        protected virtual void OnPropertyChanged ([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
