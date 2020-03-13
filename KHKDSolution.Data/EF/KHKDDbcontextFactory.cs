using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KHKDSolution.Data.EF
{
    public class KHKDDbcontextFactory : IDesignTimeDbContextFactory<KHKDDbContext>
    {
        public KHKDDbContext CreateDbContext(string[] args)
        {
            //Microsoft.Extensions.Configuration.Json
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuration.GetConnectionString("eShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<KHKDDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new KHKDDbContext(optionsBuilder.Options);

        }
    }
}
