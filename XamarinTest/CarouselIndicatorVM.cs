using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace XamarinTest
{
    public class CarouselIndicatorVM : INotifyPropertyChanged
    {
        public CarouselIndicatorVM()
        {
            MyDataSource = new List<CarouselData>() { new CarouselData() { Name = "Title11" },
                                                      new CarouselData() { Name = "Title2" },
                                                      new CarouselData() { Name = "Title3" },
                                                      new CarouselData() { Name = "Title4" }};
        }

        public List<CarouselData> MyDataSource { get; set; } // Must have default value or be set before the BindingContext is set.

        private int _position;
        public int Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
                OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

