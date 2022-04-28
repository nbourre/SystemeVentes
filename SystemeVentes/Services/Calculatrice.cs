using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SystemeVentes.Models;

namespace SystemeVentes.Services
{
    public static class Calculatrice
    {
        public static decimal CalculTPS(Product prod)
        {

            return prod.SalePrice * .05M;
            
        }

        public static decimal CalculTVQ(Product prod)
        {
            return prod.SalePrice;
        }

        public static object CalculTPSMulti(List<Product> produits)
        {
            return produits.Sum(p => p.SalePrice * .05M);                 
        }
    }
}
