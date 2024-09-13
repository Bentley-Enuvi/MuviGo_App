using Newtonsoft.Json;


namespace MuviGo.Domain.Models
{
    public class Ticket
    {
        [JsonProperty("id")]
        public string id { get; set; } = Guid.NewGuid().ToString();

        public string MovieTitle { get; set; }

        public DateTime ShowTime { get; set; }

        public string BookingStatus { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
