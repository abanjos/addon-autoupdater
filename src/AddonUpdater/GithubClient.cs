using System.Net.Http;
using Newtonsoft.Json;

namespace AddonUpdater {
    class GithubClient {
        private HttpClient _httpClient;
        private string _rootEndpoint;

        public GithubClient()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
            _httpClient.DefaultRequestHeaders.Accept.ParseAdd("application/vnd.github.v3+json");
            _rootEndpoint = "https://api.github.com";
        }

        public GithubRelease GetRepository(string repo)
        {
            var url = _rootEndpoint + "/repos/" + repo + "/releases/latest";
            var response = _httpClient.GetAsync(url).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<GithubRelease>(content);
        }
    }
}