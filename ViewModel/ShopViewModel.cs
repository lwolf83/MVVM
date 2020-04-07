using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;

namespace MVVM
{
    class ShopViewModel
    {
        public IList<Shop> ShopsList { get; set; }


        public ShopViewModel()
        {
            ShopsList = new List<Shop>
            {
                new Shop{Name = "Shop1", City="City1"},
                new Shop{Name = "Shop2", City="City2"},
                new Shop{Name = "Shop3", City="City3"},
                new Shop{Name = "Shop4", City="City4"},
                new Shop{Name = "Shop5", City="City5"},
                new Shop{Name = "Shop6", City="City6"},
                new Shop{Name = "Shop7", City="City7"},
                new Shop{Name = "Shop8", City="City8"},
            };
        }

        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private class Updater : ICommand
        {
            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {
                var test = this;
            }

        }
    }
}
