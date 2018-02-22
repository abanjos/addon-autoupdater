using Newtonsoft.Json;

namespace AddonUpdater
{
    class GithubRelease
    {
        [JsonProperty("id")]
        public int id {get;set;}
        [JsonProperty("zipball_url")]
        public string downloadUrl {get;set;}
    }
}