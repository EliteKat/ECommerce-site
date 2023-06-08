using ECommerce.Models.Identity;
using ECommerce.Models.Shop;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Models
{
	public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
	{

		public DbSet<Order> Orders { get; set; }
		public DbSet<UserOrders> UserOrders { get; set; }
		public DbSet<Checkout> Checkouts { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new OrderConfig());

			modelBuilder.ApplyConfiguration(new UserOrdersConfig());

			modelBuilder.ApplyConfiguration(new CheckoutConfig());
		}
	}
}
