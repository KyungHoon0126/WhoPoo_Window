using Newtonsoft.Json;
using WhoPoo.Model;

namespace WhoPoo.Service.Response
{
    public class MatchesResponse
    {
        [JsonProperty("result")]
        public MatchesModel Result { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }
    }
}
