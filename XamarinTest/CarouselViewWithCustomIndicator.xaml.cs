using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace XamarinTest
{
    public partial class CarouselViewWithCustomIndicator : ContentPage
    {
        public CarouselViewWithCustomIndicator()
        {
            InitializeComponent();
            //MyDataSource = new List<CarouselData>() { new CarouselData() { Name = "Title11" },
            //                                          new CarouselData() { Name = "Title2" },
            //                                          new CarouselData() { Name = "Title3" },
            //                                          new CarouselData() { Name = "Title4" }};
            //TheCarousel.ItemsSource = MyDataSource;

            BindingContext = new CarouselIndicatorVM();
        }
        //public List<CarouselData> MyDataSource { get; set; } // Must have default value or be set before the BindingContext is set.

        //private int _position;
        //public int Position { get {
        //        return _position;
        //    } set {
        //        _position = value;
        //        OnPropertyChanged();
        //    }
        //}
    }
}
