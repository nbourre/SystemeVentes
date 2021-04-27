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
            return prod.SalePrice * .05M;
        }

        public static decimal CalculTVQ(Product prod)
        {
            return prod.SalePrice;
        }
    }
}
