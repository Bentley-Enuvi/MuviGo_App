using MuviGo.Domain.Entities;
using Newtonsoft.Json;

namespace MuviGo.Domain.Models
{
    public class Actor
    {
        [JsonProperty("id")]
        public string id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
