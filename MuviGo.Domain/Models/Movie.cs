using Microsoft.AspNetCore.Http;
using MuviGo.Domain.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MuviGo.Domain.Entities
{
    public class Movie
    {
        [JsonProperty("id")]
        public string id { get; set; } = Guid.NewGuid().ToString();

        public string MovieTitle { get; set; }

        public string MovieDescription { get; set; }

        public List<Actor> Actors { get; set; }

        public List<Producer> Producers { get; set; }

        public List<Genre> Genre { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public List<FileBluePrint> PosterFile { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; } 

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
