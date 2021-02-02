using Newtonsoft.Json;

namespace WhoPoo.Model.Matches
{
    public class RunesModel
    {
        [JsonProperty("runeId")]
        public long RuneId { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }
    }
}
