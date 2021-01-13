using Newtonsoft.Json;

namespace WhoPoo.Model
{
    public class MiniSeriesModel
    {
        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }

        [JsonProperty("target")]
        public long Target { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }
    }
}
