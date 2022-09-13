using Newtonsoft.Json;

namespace MiniProject1.Models
{
    public class GenderDTO
    {
        [JsonProperty("gender")]
        public string Gender { get; set; }
    }
}
