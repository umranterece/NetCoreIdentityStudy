﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreIdentityStudy.Models.Entities;

namespace NetCoreIdentityStudy.Models.Configurations
{
    public class ProductConfiguration:BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.OrderDetails).WithOne(x => x.Product).HasForeignKey(x => x.ProductID).IsRequired();

        }
    }
}
