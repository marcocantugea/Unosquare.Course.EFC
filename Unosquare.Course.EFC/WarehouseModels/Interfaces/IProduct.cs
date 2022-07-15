using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseModels.Interfaces
{
    public interface IProduct : IModel
    {
        public int id { set; get; }
        public string name { set; get; }
        public string description { set; get; }
        public int ageRestriction { set; get; }
        public ICompany company { set; get; }
        public float price { set; get; }

    }
}
