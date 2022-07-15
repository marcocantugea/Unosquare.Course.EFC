using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseModels.Interfaces;

namespace WarehouseModels.Models
{
    public class Product : IProduct
    {
        private int _id;
        private string _name;
        private string _description;
        private int _ageRestriction;
        private int _idcompany;
        private float _price;

        public int id { get => _id; set => _id = value; }
        public string name { get => _name; set => _name = value; }
        public string description { get => _description; set => _description = value; }
        public int ageRestriction { get => _ageRestriction; set => _ageRestriction = value; }
        public int idCompany { get => _idcompany; set => _idcompany = value; }
        public float price { get => _price; set => _price = value; }
    }
}
