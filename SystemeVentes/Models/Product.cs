using System;
using System.Collections.Generic;
using System.Text;

namespace SystemeVentes.Models
{
    public class Product
    {
        public string UPC { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public decimal SalePrice { get; set; }
        public float Stock { get; set; }

        public bool TaxableFederal { get; set; } = true;
        public bool TaxableProvincial { get; set; } = true;
    }
}
