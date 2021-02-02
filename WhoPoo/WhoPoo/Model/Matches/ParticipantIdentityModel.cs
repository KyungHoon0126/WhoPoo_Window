using Newtonsoft.Json;

namespace WhoPoo.Model.Matches
{
    public class ParticipantIdentityModel
    {
        [JsonProperty("participantId")]
        public long ParticipantId { get; set; }

        [JsonProperty("player")]
        public PlayerModel Player { get; set; }
    }
}
