using System;
using System.Globalization;
using System.Windows.Data;

namespace WhoPoo.Converters
{
    public class LaneConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var lane = value as string;
            switch (lane)
            {
                case "BOTTOM":
                    return "원딜";
                case "JUNGLE":
                    return "정글";
                case "MID":
                    return "미드";
                case "NONE":
                    return "서폿";
                case "TOP":
                    return "탑";
            }

            throw new Exception("Cannot unmarshal type Lane");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
