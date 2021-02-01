using System;
using System.Globalization;
using System.Windows.Data;
using WhoPoo.Common;

namespace WhoPoo.Converters
{
    public class ChampionValueToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var champion = ComUtil.ChampionValueToNameConvert(value);
            return ComDef.CHAMPION_IMAGE_URL + champion.ToString() + ".png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
