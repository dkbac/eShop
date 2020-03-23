using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(x => x.CardID);
            builder.Property(x => x.CardID).UseIdentityColumn(); ;
            builder.HasOne(x => x.Product).WithMany(y => y.Carts).HasForeignKey(z => z.ProductID);
            builder.HasOne(x => x.User).WithMany(y => y.Carts).HasForeignKey(z => z.UserID);
        }
    }
}
