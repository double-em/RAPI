using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public int StorageAmount { get; set; }
        public Supplier Supplier { get; set; }
    }
}
