using Newtonsoft.Json;


namespace pr0p0llDiagrams.Entities.Answers
{
    public class AnswerResult
    {
        [JsonProperty(PropertyName = "total")]
        public int Total{ get; set; }

        [JsonProperty(PropertyName = "gender")]
        public GenderResult Gender{ get; set; }

        [JsonProperty(PropertyName = "age")]
        public AgeResult Age{ get; set; }

        [JsonProperty(PropertyName = "country")]
        public CountryResult Country{ get; set; }
    }
}
