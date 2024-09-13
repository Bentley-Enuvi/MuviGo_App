using Newtonsoft.Json;


namespace MuviGo.Domain.Models
{
    public class Genre
    {
        [JsonProperty("id")]
        public string id { get; set; } = Guid.NewGuid().ToString();

        public string MovieId { get; set; }

        public string GenreName { get; set; }
    }
}
