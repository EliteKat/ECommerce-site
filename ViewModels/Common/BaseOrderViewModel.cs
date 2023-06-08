using ECommerce.ViewModels.Interfaces;

namespace ECommerce.ViewModels.Common
{
	public class BaseOrderViewModel : IOrderViewModel
	{
		public string Title { get; set; } = default!;
		public int Price { get; set; }
	}
}
