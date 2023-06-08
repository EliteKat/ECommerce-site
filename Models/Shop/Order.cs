using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Models.Shop
{
    public class Order
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Price { get; set; }
        public string? Description { get; set; }
        public string? PhotoSrc { get; set; }
    }

	public class OrderConfig : IEntityTypeConfiguration<Order>
	{
		public void Configure(EntityTypeBuilder<Order> builder)
		{
			builder.HasData(
				new Order { Id = 1, Title = "Reef Boardsport", Price = 200, PhotoSrc = "/images/shop/products/product-1.jpg" },
				new Order { Id = 2, Title = "Reef Rainbow", Price = 300, PhotoSrc = "/images/shop/products/product-2.jpg" },
				new Order { Id = 3, Title = "Reef Strayhorn", Price = 250, PhotoSrc = "/images/shop/products/product-3.jpg" },
				new Order { Id = 4, Title = "Reef Bradley Mid", Price = 500, PhotoSrc = "/images/shop/products/product-4.jpg" },
				new Order { Id = 5, Title = "Reef Pants", Price = 700, PhotoSrc = "/images/shop/products/product-5.jpg" },
				new Order { Id = 6, Title = "Reef T-Shirt", Price = 1000, PhotoSrc = "/images/shop/products/product-6.jpg" },
				new Order { Id = 7, Title = "Reef Skirt", Price = 800, PhotoSrc = "/images/shop/products/product-7.jpg" }
			);
		}
	}

}
