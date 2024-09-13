using Newtonsoft.Json;

namespace MuviGo.Domain.Models
{
    public class FileBluePrint
    {
        [JsonProperty("id")]
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string FileUrl { get; set; } = string.Empty;
        public long FileSize { get; set; }
        public string FileName { get; set; }
        public string ProductId { get; set; }
        public string ContentType { get; set; }
    }
}
