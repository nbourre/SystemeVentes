using System;
using System.Collections.Generic;
using System.Text;

namespace SystemeVentes.Models
{
    public class FactureController
    {
        public static void FactureAddProduct(Facture fact, Product prod)
        {
            if (fact.FactureDetails == null) 
                fact.FactureDetails = new List<FactureDetail>();

            var fd = new FactureDetail(fact, prod, 1);
            fact.FactureDetails.Add(fd);
        }

        public static void FactureRemoveProduct(Facture fact, Product prod)
        {

        }
    }
}
