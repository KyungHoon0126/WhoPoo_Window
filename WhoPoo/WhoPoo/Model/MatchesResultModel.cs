using Newtonsoft.Json;

namespace WhoPoo.Model
{
    public class MatchesResultModel
    {
        [JsonProperty("result")]
        public MatchesResultModel Result { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }
    }
}
