using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;


namespace MuviGo.Domain.Models
{
    public class CartHeader
    {
        [JsonProperty("id")]
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string UserId { get; set; }

        [NotMapped]
        public double CartTotal { get; set; }
    }
}
