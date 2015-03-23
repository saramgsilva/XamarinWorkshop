using System;
using System.Globalization;
using Xamarin.Forms;

namespace ENEI.SessionsApp.Converters
{
    public class FavoriteImageConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return Device.OS == TargetPlatform.WinPhone ? "Images/ic_action_heart.png" : "ic_action_heart.png";
            }
            var isFavorite = (bool) value;

            if (isFavorite)
            {
                return Device.OS == TargetPlatform.WinPhone ? "Images/ic_action_heart_red.png" : "ic_action_heart_red.png";
            }
            return Device.OS == TargetPlatform.WinPhone ? "Images/ic_action_heart.png" : "ic_action_heart.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
