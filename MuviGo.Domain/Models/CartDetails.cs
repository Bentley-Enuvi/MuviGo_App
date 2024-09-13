using MuviGo.Domain.Entities;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;


namespace MuviGo.Domain.Models
{
    public class CartDetails
    {
        [JsonProperty("id")]
        public string id { get; set; } = Guid.NewGuid().ToString();

        public int CartHeaderId { get; set; }

        public CartHeader CartHeader { get; set; }

        [NotMapped]
        public Movie Movie { get; set; }

        public int Count { get; set; }
    }
}
