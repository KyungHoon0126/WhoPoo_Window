using Newtonsoft.Json;
using System.Collections.Generic;

namespace WhoPoo.Model
{
    public class MatchListResultModel
    {
        [JsonProperty("matches")]
        public List<MatchListModel> Matches { get; set; }

        [JsonProperty("startIndex")]
        public long StartIndex { get; set; }

        [JsonProperty("endIndex")]
        public long EndIndex { get; set; }

        [JsonProperty("totalGames")]
        public long TotalGames { get; set; }
    }
}
