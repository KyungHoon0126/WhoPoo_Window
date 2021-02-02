using Newtonsoft.Json;

namespace WhoPoo.Model.Matches
{
    public class MasteriesModel
    {
        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("masteryId")]
        public long MasteryId { get; set; }
    }
}
