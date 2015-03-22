using System;
using System.Globalization;
using Xamarin.Forms;

namespace ENEI.SessionsApp.Converters
{
    public class FavoriteImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                if (Device.OS == TargetPlatform.WinPhone)
                {
                    return "Images/ic_action_heart.png";
                }
                if (Device.OS == TargetPlatform.iOS)
                {
                    return "http://s20.postimg.org/qng9erqvt/ic_action_heart.png";
                }
                return "ic_action_heart.png";
            }
            var isFavorite = (bool) value;

            if (isFavorite)
            {
                if (Device.OS == TargetPlatform.WinPhone)
                {
                    return "Images/ic_action_heart_red.png";
                }
                if (Device.OS == TargetPlatform.iOS)
                {
                    return "http://s20.postimg.org/jbat988nt/ic_action_heart_red.png";
                }
                return "ic_action_heart_red.png";
            }
            if (Device.OS == TargetPlatform.WinPhone)
            {
                return "Images/ic_action_heart.png";
            }
            if (Device.OS == TargetPlatform.iOS)
            {
                return "http://s20.postimg.org/qng9erqvt/ic_action_heart.png";
            }
            return "ic_action_heart.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
