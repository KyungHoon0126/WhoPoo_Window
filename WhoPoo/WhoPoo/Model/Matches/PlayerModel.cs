using Newtonsoft.Json;

namespace WhoPoo.Model
{
    public enum PlatformId 
    {
        Kr 
    };

    public class PlayerModel
    {
        [JsonProperty("profileIcon")]
        public long ProfileIcon { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("matchHistoryUri")]
        public string MatchHistoryUri { get; set; }

        [JsonProperty("currentAccountId")]
        public string CurrentAccountId { get; set; }

        [JsonProperty("currentPlatformId")]
        public PlatformId CurrentPlatformId { get; set; }

        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }

        [JsonProperty("summonerId")]
        public string SummonerId { get; set; }

        [JsonProperty("platformId")]
        public PlatformId PlatformId { get; set; }
    }
}
