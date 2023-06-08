using ECommerce.ViewModels.Common;

namespace ECommerce.ViewModels.Shop
{
    public class CheckoutViewModel
    {
		public string Fullname { get; set; }
		public string Address { get; set; }
		public int ZipCode { get; set; }
		public string City { get; set; }
		public string Country { get; set; }

		public int CardNumber { get; set; }
		public int ExpiryMonth { get; set; }
		public int ExpiryYear { get; set; }
		public int CardCode { get; set; }


		public List<BaseOrderViewModel> Orders { get; set; }
	}
}
