﻿using Newtonsoft.Json;
using WhoPoo.Model;

namespace WhoPoo.Service.Response
{
    public class MatchListResponse
    {
        [JsonProperty("result")]
        public MatchListResultModel Result { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }
}
