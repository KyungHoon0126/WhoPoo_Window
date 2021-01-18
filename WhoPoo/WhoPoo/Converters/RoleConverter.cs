using System;
using System.Globalization;
using System.Windows.Data;

namespace WhoPoo.Converters
{
    public class RoleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var role = value as string;

            switch (role)
            {
                case "DUO":
                    return "듀오";
                case "DUO_SUPPORT":
                    return "듀오 서포트";
                case "DUO_CARRY":
                    return "듀오 캐리";
                case "NONE":
                    return "없음";
                case "SOLO":
                    return "솔로";
            }

            throw new Exception("Cannot unmarshal type Role");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
