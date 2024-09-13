namespace MuviGo_UI.ViewModels
{
    public class CartViewModel
    {
        public CartHeaderViewModel CartHeader { get; set; }
        public IList<CartDetailsViewModel> CartDetails { get; set; }

    }
}
