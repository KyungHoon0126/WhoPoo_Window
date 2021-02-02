using Newtonsoft.Json;
using System.Collections.Generic;

namespace WhoPoo.Model
{
    public class MatchesModel
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }

        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("gameCreation")]
        public long GameCreation { get; set; }

        [JsonProperty("gameDuration")]
        public long GameDuration { get; set; }

        [JsonProperty("queueId")]
        public long QueueId { get; set; }

        [JsonProperty("mapId")]
        public long MapId { get; set; }

        [JsonProperty("seasonId")]
        public long SeasonId { get; set; }

        [JsonProperty("gameVersion")]
        public string GameVersion { get; set; }

        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        [JsonProperty("gameType")]
        public string GameType { get; set; }

        [JsonProperty("teams")]
        public List<TeamModel> Teams { get; set; }

        [JsonProperty("participants")]
        public List<ParticipantModel> Participants { get; set; }

        [JsonProperty("participantIdentities")]
        public List<ParticipantIdentityModel> ParticipantIdentities { get; set; }
    }
}
