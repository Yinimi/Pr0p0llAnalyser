using System.Collections.Generic;
using Newtonsoft.Json;


namespace pr0p0llDiagrams.Entities
{
    public class Poll
    {
        [JsonProperty(PropertyName = "pollid")]
        public int Pollid{ get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title{ get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description{ get; set; }

        [JsonProperty(PropertyName = "author")]
        public string Author{ get; set; }

        [JsonProperty(PropertyName = "duration")]
        public long Duration{ get; set; }

        [JsonProperty(PropertyName = "endedOn")]
        public long EndedOn{ get; set; }

        [JsonProperty(PropertyName = "resultFile")]
        public string ResultFile{ get; set; }

        [JsonProperty(PropertyName = "categoryID")]
        public int CategoryId{ get; set; }

        [JsonProperty(PropertyName = "categoryTitle")]
        public string CategoryTitle{ get; set; }

        public List<Question> Questions{ get; set; }
    }
}
