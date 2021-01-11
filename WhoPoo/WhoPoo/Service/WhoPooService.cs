using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;
using WhoPoo.Service.Response;

namespace WhoPoo.Service
{
    public class WhoPooService
    {
        private const string GET_MATCHES_URL = "/matches/";
        private const string GET_MATCH_LIST_URL = "/matchlists/";

        private RestClient client;
        private RestRequest request;

        public WhoPooService()
        {
            client = new RestClient(Config.SERVER_ADDRESS);
            request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
        }

        /// <summary>
        /// 유저 이름을 입력받아 최근 게임 전적 반환
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public async Task<MatchListResponse> GetMatchList(string name, int startIndex = 0, int endIndex = 0)
        {
            string requestUrl = GET_MATCH_LIST_URL + name;
            SetRestRequest(requestUrl, Method.GET);
            var response = await client.ExecuteAsync(request);
            return JsonConvert.DeserializeObject<MatchListResponse>(response.Content);
        }

        /// <summary>
        /// 특정 게임 ID를 입력받아 해당 게임에 대한 정보 반환
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        public async Task<MatchesResponse> GetMatches(long gameId)
        {
            string requestUrl = GET_MATCHES_URL + gameId;
            SetRestRequest(requestUrl, Method.GET);
            var response = await client.ExecuteAsync(request);
            return JsonConvert.DeserializeObject<MatchesResponse>(response.Content);
        }

        private void SetRestRequest(string resource, Method method)
        {
            request.Resource = resource;
            request.Method = method;
        }
    }
}
