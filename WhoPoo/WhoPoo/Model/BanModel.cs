using Newtonsoft.Json;

namespace WhoPoo.Model
{
    public class BanModel
    {
        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("pickTurn")]
        public long PickTurn { get; set; }
    }
}
