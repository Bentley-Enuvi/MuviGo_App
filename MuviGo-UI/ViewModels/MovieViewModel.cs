using System.ComponentModel.DataAnnotations;

namespace MuviGo_UI.ViewModels
{
    public class MovieViewModel
    {
        public string MovieTitle { get; set; }

        public string MovieDescription { get; set; }

        public IList<DirectorViewModel> Directors { get; set; }

        public IList<ActorViewModel> Actors { get; set; }

        public IList<ProducerViewModel> Producers { get; set; }

        public string Genre { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public IList<IFormFile> Files { get; set; } = new List<IFormFile>();

        public decimal Price { get; set; }
    }
}
