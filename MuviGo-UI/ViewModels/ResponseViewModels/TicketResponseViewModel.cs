using MuviGo.Domain.Enums;

namespace MuviGo_UI.ViewModels.ResponseViewModels
{
    public class TicketResponseViewModel
    {
        public string id { get; set; } 

        public string MovieTitle { get; set; }

        public DateTime ShowTime { get; set; }

        public BookingStatus BookingStatus { get; set; }

        public decimal Price { get; set; }
    }
}
