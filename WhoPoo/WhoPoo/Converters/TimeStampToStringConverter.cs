using System;
using System.Globalization;
using System.Windows.Data;

namespace WhoPoo.Converters
{
    public class TimeStampToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var timeSpan = DateTime.Now.Subtract((DateTime)value);

            if (timeSpan <= TimeSpan.FromSeconds(60))
            {
                return string.Format("{0}초 전", timeSpan.Seconds);
            }
            else if (timeSpan <= TimeSpan.FromMinutes(60))
            {
                return timeSpan.Minutes > 1 ? string.Format("{0}분 전", timeSpan.Minutes) : "몇분 전";
            }
            else if (timeSpan <= TimeSpan.FromHours(24))
            {
                return timeSpan.Hours > 1 ? string.Format("{0}시간 전", timeSpan.Hours) : "몇시간 전";
            }
            else if (timeSpan <= TimeSpan.FromDays(30))
            {
                return timeSpan.Days > 1 ? string.Format("{0}일 전", timeSpan.Days) : "어제";
            }
            else if (timeSpan <= TimeSpan.FromDays(365))
            {
                return timeSpan.Days > 30 ? string.Format("{0}달 전", timeSpan.Days / 30) : "몇달 전";
            }
            else
            {
                return timeSpan.Days > 365 ? string.Format("{0}년 전", timeSpan.Days / 365) : "몇년 전";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
