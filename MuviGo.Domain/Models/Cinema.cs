using MuviGo.Domain.Enums;
using Newtonsoft.Json;

namespace MuviGo.Domain.Models
{
    public class Cinema
    {
        [JsonProperty("id")]
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Description { get; set; }
        public string MovieTitle { get; set; }
        public IList<Actor> Actors { get; set; }
        public IList<Producer> Producers { get; set; }
        public DateTime ReleaseDate { get; set; }
        public MovieStatus Status { get; set; }
    }
}
