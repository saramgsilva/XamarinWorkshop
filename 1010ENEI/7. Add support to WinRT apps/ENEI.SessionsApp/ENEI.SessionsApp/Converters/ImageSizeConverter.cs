using System;
using System.Globalization;
using Xamarin.Forms;

namespace ENEI.SessionsApp.Converters
{
    public class ImageSizeConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {

                if (Device.OS == TargetPlatform.Android || Device.OS == TargetPlatform.Windows)
                {
                    return 48;
                }
                if (Device.OS == TargetPlatform.iOS)
                {
                    return 30;
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
