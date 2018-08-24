using Newtonsoft.Json;


namespace pr0p0llDiagrams.Entities.Answers
{
    public class CountryResult
    {
        [JsonProperty("de")]
        public int De{ get; set; }

        [JsonProperty("at")]
        public int At{ get; set; }

        [JsonProperty("ch")]
        public int Ch{ get; set; }

        [JsonProperty("other")]
        public int Other{ get; set; }
    }
}
