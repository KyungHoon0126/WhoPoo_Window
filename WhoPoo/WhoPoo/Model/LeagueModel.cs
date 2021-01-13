using Newtonsoft.Json;
using System;

namespace WhoPoo.Model
{
    public class LeagueModel
    {
        [JsonProperty("leagueId")]
        public Guid LeagueId { get; set; }

        [JsonProperty("summonerId")]
        public string SummonerId { get; set; }

        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }

        [JsonProperty("queueType")]
        public string QueueType { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("leaguePoints")]
        public long LeaguePoints { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }

        [JsonProperty("hotStreak")]
        public bool HotStreak { get; set; }

        [JsonProperty("veteran")]
        public bool Veteran { get; set; }

        [JsonProperty("freshBlood")]
        public bool FreshBlood { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("miniSeries")]
        public MiniSeriesModel MiniSeries { get; set; }
    }
}
