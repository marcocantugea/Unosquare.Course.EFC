using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseCoreLib.DataAccess;

namespace Tests.WarehouseEFlib_test
{
    public class WarehouseDBContext_unitTest
    {
 
        [Fact]
        public void test_WarehouseDbContext_getContext()
        {
            WarehouseDbContext dbcontext= WarehouseHelper.createDBContext();
            Assert.NotNull(dbcontext);
            
        }
    }
}
