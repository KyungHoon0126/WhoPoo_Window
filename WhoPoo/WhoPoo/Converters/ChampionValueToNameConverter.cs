using System;
using System.Globalization;
using System.Windows.Data;
using WhoPoo.Common;

namespace WhoPoo.Converters
{
    public class ChampionValueToNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //var championValue = (long)value;
            //return EChampionsModel.EChampions.Where(x => (int)x == championValue).FirstOrDefault();
            
            return ComUtil.ChampionValueToNameConvert(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
