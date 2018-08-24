using Newtonsoft.Json;


namespace pr0p0llDiagrams.Entities.Answers
{
    public class GenderResult
    {
        [JsonProperty("m")]
        public int M{ get; set; }

        [JsonProperty("w")]
        public int W{ get; set; }
    }
}
