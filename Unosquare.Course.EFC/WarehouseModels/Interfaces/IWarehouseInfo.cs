using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseModels.Interfaces
{
    public interface IWarehouseInfo : IModel
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public string _code { get; set; }
        public bool _active { get; set; }

    }
}
