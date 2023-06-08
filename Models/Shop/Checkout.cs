using ECommerce.Models.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models.Shop
{
	public class Checkout
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
		public string Fullname { get; set; } = default!;
		public string Address { get; set; } = default!;
		public int ZipCode { get; set; }
		public string City { get; set; } = default!;
		public string Country { get; set; } = default!;

		public int CardNumber { get; set; }
		public int ExpiryMonth { get; set; }
		public int ExpiryYear { get; set; }
		public int CardCode { get; set; }
	}

	public class CheckoutConfig : IEntityTypeConfiguration<Checkout>
	{
		public void Configure(EntityTypeBuilder<Checkout> builder)
		{
			builder.HasOne(c => c.User)
				   .WithMany()
				   .HasForeignKey(c => c.UserId)
				   .IsRequired();
		}

	}

}
