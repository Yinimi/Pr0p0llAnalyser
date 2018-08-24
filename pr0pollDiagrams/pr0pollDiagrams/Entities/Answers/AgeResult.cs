using Newtonsoft.Json;


namespace pr0p0llDiagrams.Entities.Answers
{
    public class AgeResult
    {
        [JsonProperty("@<18")]
        public int U18{ get; set; }


        [JsonProperty("@18-23")]
        // ReSharper disable once InconsistentNaming
        public int B18_23{ get; set; }


        [JsonProperty("@24-29")]
        // ReSharper disable once InconsistentNaming
        public int B24_29{ get; set; }


        [JsonProperty("@30-38")]
        // ReSharper disable once InconsistentNaming
        public int B30_38{ get; set; }


        [JsonProperty("@39-48")]
        // ReSharper disable once InconsistentNaming
        public int B39_48{ get; set; }


        [JsonProperty("@49-55")]
        // ReSharper disable once InconsistentNaming
        public int B49_55{ get; set; }


        [JsonProperty("@55>")]
        public int O55{ get; set; }
    }
}
