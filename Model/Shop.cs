using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace MVVM
{
    class Shop : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string City { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
