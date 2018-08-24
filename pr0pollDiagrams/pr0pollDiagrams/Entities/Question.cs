using System.Collections.Generic;
using Newtonsoft.Json;
using pr0p0llDiagrams.Entities.Answers;


namespace pr0p0llDiagrams.Entities
{
    public class Question
    {
        [JsonProperty(PropertyName = "id")]
        public int Id{ get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title{ get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description{ get; set; }

        [JsonProperty(PropertyName = "answertype")]
        public string Answertype{ get; set; }

        [JsonProperty(PropertyName = "index")]
        public int Index{ get; set; }

        public List<Answer> Answers{ get; set; }
    }
}
