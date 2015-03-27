
using System;
using System.Globalization;
using Xamarin.Forms;

namespace ENEI.SessionsApp.Converters
{
    public class RowHeightConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {

                if (Device.OS == TargetPlatform.Android || Device.OS == TargetPlatform.iOS)
                {
                    return 150;
                }
                if (Device.OS == TargetPlatform.WinPhone)
                {
                    return 180;
                }
                if (Device.OS == TargetPlatform.Windows)
                {
                    return 200;
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
