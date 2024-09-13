using MuviGo.Domain.Models;
using Newtonsoft.Json;

namespace MuviGo_UI.ViewModels.ResponseViewModels
{
    public class MovieResponseViewModel
    {
        public string id { get; set; }

        public string MovieTitle { get; set; }

        public string MovieDescription { get; set; }

        public List<Actor> Actors { get; set; }

        public List<Producer> Producers { get; set; }

        public List<Genre> Genres { get; set; }

        public DateTime ReleaseDate { get; set; }

        public List<FileBluePrint> PosterFile { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
