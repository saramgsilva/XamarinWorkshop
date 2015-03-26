using System;
using System.Globalization;
using Xamarin.Forms;

namespace ENEI.SessionsApp.Converters
{
    public class ImageUrlConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter !=null && !string.IsNullOrEmpty(parameter.ToString()))
            {
                var imageUrl = string.Empty;
                switch (parameter.ToString())
                {
                    case "Like":
                        imageUrl= Device.OS == TargetPlatform.WinPhone || Device.OS == TargetPlatform.Windows ?
                        "Images/ic_action_like.png":
                        "ic_action_like.png";
                        break;
                    case "Share":
                        imageUrl = Device.OS == TargetPlatform.WinPhone || Device.OS == TargetPlatform.Windows ?
                       "Images/ic_action_share_2.png" :
                       "ic_action_share_2.png";
                        break;
                    case "Details":
                        imageUrl = Device.OS == TargetPlatform.WinPhone || Device.OS == TargetPlatform.Windows ?
                       "Images/ic_action_list.png" :
                       "ic_action_list.png";
                        break;
                }

                return ImageSource.FromFile(imageUrl);
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
