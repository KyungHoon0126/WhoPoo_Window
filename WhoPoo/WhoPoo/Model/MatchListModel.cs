using Newtonsoft.Json;

namespace WhoPoo.Model
{
    public class MatchListModel
    {
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("gameId")]
        public long GameId { get; set; }

        [JsonProperty("champion")]
        public long Champion { get; set; }

        [JsonProperty("queue")]
        public long Queue { get; set; }

        [JsonProperty("season")]
        public long Season { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("lane")]
        public string Lane { get; set; }
    }
}
