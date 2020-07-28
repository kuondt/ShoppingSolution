using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingSolution.Data.Entities;
using ShoppingSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSolution.Data.Configurations
{
    class CategoryConfiguaration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}
