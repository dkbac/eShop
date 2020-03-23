using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");
            builder.HasKey(x => new { x.CategoryID, x.ProductID});
            builder.HasOne(x => x.Product).WithMany(y => y.ProductInCategories).HasForeignKey(z => z.ProductID);
            builder.HasOne(x => x.Category).WithMany(y => y.ProductInCategories).HasForeignKey(z => z.CategoryID);
        }
    }
}
