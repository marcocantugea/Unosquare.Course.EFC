using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseConsoleEF
{
    public class SQLWarehouseDBContext : WarehouseCoreLib.DataAccess.WarehouseDbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=.\SQLEXPRESS;Database=dev_warehouse;Trusted_Connection=True;MultipleActiveResultSets=true;");
    }
}
