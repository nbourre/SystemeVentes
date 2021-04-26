using System;
using System.Collections.Generic;
using System.Text;

namespace SystemeVentes.Models
{
    public class Facture
    {
        public DateTime DateCreation { get; set; }

        public float Total { get; set; }
        public int NbItems { get; set; }

        public List<Product> Produits { get; set; }
    }
}
