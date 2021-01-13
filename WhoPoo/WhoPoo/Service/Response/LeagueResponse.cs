using Newtonsoft.Json;
using System.Collections.Generic;
using WhoPoo.Model;

namespace WhoPoo.Service.Response
{
    public class LeagueResponse
    {
        [JsonProperty("result")]
        public List<LeagueModel> Result { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }
    }
}
