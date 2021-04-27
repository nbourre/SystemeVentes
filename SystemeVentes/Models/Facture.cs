using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemeVentes.Models
{
    public class Facture
    {
        public DateTime DateCreation { get; set; }

        public Decimal Total => Produits.Sum(x => x.SalePrice);

        public int NbItems => Produits.Count();

        public List<Product> Produits { get; set; }
    }
}
