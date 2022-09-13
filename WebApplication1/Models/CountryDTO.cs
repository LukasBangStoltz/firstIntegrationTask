
using Newtonsoft.Json;

namespace MiniProject1.Models
{
    public class CountryDTO
    {
        [JsonProperty("country_code2")]
        public string Country { get; set; }
    }
}
