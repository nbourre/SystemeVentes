using System;
using System.Collections.Generic;
using System.Text;

namespace SystemeVentes.Models
{
    public class Produit
    {
        public string Nom { get; set; }
        public decimal PrixVente { get; set; }
        public float Stock { get; set; }

        public bool TaxableFederal { get; set; } = true;
        public bool TaxableProvincial { get; set; } = true;
    }
}
