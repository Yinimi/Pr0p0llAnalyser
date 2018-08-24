using Newtonsoft.Json;


namespace pr0p0llDiagrams.Entities.Answers
{
    public class Answer
    {
        [JsonProperty(PropertyName = "id")]
        public int Id{ get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title{ get; set; }

        [JsonProperty(PropertyName = "index")]
        public int Index{ get; set; }

        [JsonProperty(PropertyName = "result")]
        public AnswerResult Result{ get; set; }
    }
}
