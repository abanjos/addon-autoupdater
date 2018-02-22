
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AddonUpdater {
    class Config {
        
        [JsonProperty("version")]
        public string Version{ get; set; }
        
        [JsonProperty("wow_path")]
        public string  WowPath { get; set; }
        
        [JsonProperty("addons")]
        public List<string> Addons { get; set; }
    }
    
}