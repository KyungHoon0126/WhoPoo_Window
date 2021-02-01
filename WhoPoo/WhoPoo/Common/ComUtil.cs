using System.Linq;
using WhoPoo.Model.Enums;

namespace WhoPoo.Common
{
    public class ComUtil
    {
        public static EChampions ChampionValueToNameConvert(object value)
        {
            var championValue = (long)value;
            return EChampionsModel.EChampions.Where(x => (int)x == championValue).FirstOrDefault();
        }
    }
}
