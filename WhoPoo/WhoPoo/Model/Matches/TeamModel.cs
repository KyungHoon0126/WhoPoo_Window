using Newtonsoft.Json;
using System.Collections.Generic;

namespace WhoPoo.Model
{
    public class TeamModel
    {
        [JsonProperty("teamId")]
        public long TeamId { get; set; }

        [JsonProperty("win")]
        public string Win { get; set; }

        [JsonProperty("firstBlood")]
        public bool FirstBlood { get; set; }

        [JsonProperty("firstTower")]
        public bool FirstTower { get; set; }

        [JsonProperty("firstInhibitor")]
        public bool FirstInhibitor { get; set; }

        [JsonProperty("firstBaron")]
        public bool FirstBaron { get; set; }

        [JsonProperty("firstDragon")]
        public bool FirstDragon { get; set; }

        [JsonProperty("firstRiftHerald")]
        public bool FirstRiftHerald { get; set; }

        [JsonProperty("towerKills")]
        public long TowerKills { get; set; }

        [JsonProperty("inhibitorKills")]
        public long InhibitorKills { get; set; }

        [JsonProperty("baronKills")]
        public long BaronKills { get; set; }

        [JsonProperty("dragonKills")]
        public long DragonKills { get; set; }

        [JsonProperty("vilemawKills")]
        public long VilemawKills { get; set; }

        [JsonProperty("riftHeraldKills")]
        public long RiftHeraldKills { get; set; }

        [JsonProperty("dominionVictoryScore")]
        public long DominionVictoryScore { get; set; }

        [JsonProperty("bans")]
        public List<BanModel> Bans { get; set; }
    }
}
