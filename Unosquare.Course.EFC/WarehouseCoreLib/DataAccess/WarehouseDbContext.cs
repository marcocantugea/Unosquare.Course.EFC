using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WarehouseModels.Models;

namespace WarehouseCoreLib.DataAccess
{
    public class WarehouseDbContext : DbContext 
    {
        public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options) : base(options)
        {
        }

        public static WarehouseDbContext GetWarehouseDbContext(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WarehouseDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new WarehouseDbContext(optionsBuilder.Options);
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
