using System;
using System.Globalization;
using System.Windows.Data;

namespace MovingStimulus
{
    public class RatioConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var xRatio = (double)values[0];
            var width = (double)values[1];
            var realX = xRatio * width;
            return realX;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}