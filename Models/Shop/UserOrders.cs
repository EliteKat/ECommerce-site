using ECommerce.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models.Shop
{
    public class UserOrders
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }

    public class UserOrdersConfig : IEntityTypeConfiguration<UserOrders>
    {
        public void Configure(EntityTypeBuilder<UserOrders> builder)
        {
            builder.HasOne<User>(uo => uo.User)
                   .WithMany()
                   .HasForeignKey(f => f.UserId)
                   .IsRequired();

            builder.HasOne<Order>(uo => uo.Order)
                   .WithMany()
                   .HasForeignKey(f => f.OrderId)
                   .IsRequired();
        }
    }
}
