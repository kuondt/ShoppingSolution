using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSolution.Data.Configurations
{
    class AppRoleConfiguaration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.ToTable("AppRoles");

            builder.Property(x => x.Description);
        }
    }
}
