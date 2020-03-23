using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(x => x.OrderDetailID);
            builder.Property(x => x.OrderDetailID).UseIdentityColumn();
            builder.HasOne(x => x.Order).WithMany(y => y.OrderDetails).HasForeignKey(z => z.OrderID);
            builder.HasOne(x => x.Product).WithMany(y => y.OrderDetails).HasForeignKey(z => z.ProductID);
        }
    }
}
