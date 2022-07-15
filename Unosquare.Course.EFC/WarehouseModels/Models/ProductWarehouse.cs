﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseModels.Models
{
    public class ProductWarehouse
    {
        [ForeignKey("Products")]
        public int productId { get; set; }

        [ForeignKey("Warehouses")]
        public int warehouseId { get; set; }
        public int stock { get; set; }  

    }
}
