using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinTest
{
    public class MyColorConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color color = Color.Gray;
            bool position = (bool)value;
            switch (position)
            {
                case true:
                    color =  Color.Red;//Purple;
                    break;
                case false:
                    color =  Color.Yellow;//Gray
                    break;
            }
            return color;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            Color color = Color.Gray;
            bool position = (bool)value;
            switch (position)
            {
                case true:
                    color = Color.Red;//Color.FromHex("c2bca8");
                    break;
                case false:
                    color = Color.Yellow;
                    break;
            }
            return color;

        }
    }
}
