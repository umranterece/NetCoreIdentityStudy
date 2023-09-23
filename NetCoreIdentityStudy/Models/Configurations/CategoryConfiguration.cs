﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreIdentityStudy.Models.Entities;

namespace NetCoreIdentityStudy.Models.Configurations
{
    public class CategoryConfiguration:BaseConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.Products).WithOne(x => x.Category).HasForeignKey(x => x.CategoryID);
        }
    }
}
