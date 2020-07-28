using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShoppingSolution.Data.EF
{
    public class ShoppingSolutionDBContextFactory : IDesignTimeDbContextFactory<ShoppingDBContext>
    {
        public ShoppingDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ShoppingSolution_Database");

            var optionsBuilder = new DbContextOptionsBuilder<ShoppingDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ShoppingDBContext(optionsBuilder.Options);
        }
    }
}
