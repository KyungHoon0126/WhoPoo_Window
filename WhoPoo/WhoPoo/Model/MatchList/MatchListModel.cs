using Newtonsoft.Json;
using System;

namespace WhoPoo.Model
{
    public class MatchListModel : ICloneable
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
        public long TimeStamp { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("lane")]
        public string Lane { get; set; }

        [JsonProperty("time")]
        public DateTime Time { get; set; }

        public object Clone()
        {
            return new MatchListModel()
            {
                PlatformId = this.PlatformId,
                GameId = this.GameId,
                Champion = this.Champion,
                Queue = this.Queue,
                Season = this.Season,
                TimeStamp = this.TimeStamp,
                Role = this.Role,
                Lane = this.Lane,
                Time = this.Time
            };
        }
    }
}
