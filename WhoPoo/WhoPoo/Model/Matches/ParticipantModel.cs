using Newtonsoft.Json;

namespace WhoPoo.Model.Matches
{
    public class ParticipantModel
    {
        [JsonProperty("participantId")]
        public long ParticipantId { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("teamId")]
        public long TeamId { get; set; }

        [JsonProperty("spell1Id")]
        public long Spell1Id { get; set; }

        [JsonProperty("spell2Id")]
        public long Spell2Id { get; set; }

        [JsonProperty("highestAchievedSeasonTier")]
        public string HighestAchievedSeasonTier { get; set; }

        [JsonProperty("runes")]
        public RunesModel Runes { get; set; }

        [JsonProperty("stats")]
        public StatsModel Stats { get; set; }

        [JsonProperty("timeline")]
        public TimelineModel Timeline { get; set; }

        [JsonProperty("masteries")]
        public MasteriesModel Masteries { get; set; }
    }
}
