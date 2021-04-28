using System;
using System.Collections.Generic;
using System.Text;
using SystemeVentes.Models;

namespace SystemeVentes.Services
{
    public static class Calculatrice
    {
        public static decimal CalculTPS(Product prod)
        {
            if (prod == null) throw new ArgumentNullException("Produit ne peut être null");

            if (!prod.TaxableFederal) return 0.0M;            

            return prod.SalePrice * .05M;
        }

        public static decimal CalculTVQ(Product prod)
        {
            return prod.SalePrice;
        }
    }
}
