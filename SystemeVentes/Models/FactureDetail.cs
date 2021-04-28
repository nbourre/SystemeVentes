using System;
using System.Collections.Generic;
using System.Text;

namespace SystemeVentes.Models
{
    public class FactureDetail
    {
        public Facture Facture { get; private set; }
        public Product Product { get; private set; }
        public float Quantity { get; private set; }

        public decimal SousTotal => Product.SalePrice * (decimal)Quantity;
        public decimal TPS { get; internal set; }
        public decimal TVQ { get; internal set; }

        public FactureDetail(Facture facture, Product product, int quantity = 1)
        {
            Facture = facture;

            Product = new Product { 
                SalePrice = product.SalePrice, 
                TaxableFederal = product.TaxableFederal, 
                TaxableProvincial = product.TaxableProvincial
            };

            /// TODO : Récupérer les taux de taxes
            /// 

            Quantity = quantity;
        }
    }
}
