using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinTest
{
    public class CarouselIndicatorVM : INotifyPropertyChanged
    {
        public ICommand NextClickCommand { get; private set; }
        public ICommand PreviousClickCommand { get; private set; }
        public CarouselIndicatorVM()
        {
            MyDataSource = new List<CarouselData>() { new CarouselData() { Name = "Title11" },
                                                      new CarouselData() { Name = "Title2" },
                                                      new CarouselData() { Name = "Title3" },
                                                      };
            NextClickCommand = new Command(NextClick);

            PreviousClickCommand = new Command(PreviousClick);

        }

        void NextClick()
        {
            Console.WriteLine("next " + Position + MyDataSource.Count);
            if (Position < MyDataSource.Count - 1)
            {
                Position += 1;
            }

        }

        void PreviousClick()
        {

            if (Position != 0)
            {
                Position -= 1;
            }
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

