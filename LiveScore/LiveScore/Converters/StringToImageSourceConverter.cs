namespace LiveScore.Converters
{
    using System;
    using System.Globalization;
    using Xamarin.Forms;

    public sealed class StringToImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var location = value as string;

            if (location == null)
            {
                return null;
            }

            return new ImageSourceConverter().ConvertFromInvariantString(location);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}