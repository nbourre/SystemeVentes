using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemeVentes.Models
{
    public class Facture
    {
        public DateTime DateCreation { get; set; }

        public decimal SousTotal => FactureDetails.Sum(fd => fd.SousTotal);

        public decimal TotalTPS => FactureDetails.Sum(fd => fd.TPS);
        public decimal TotalTVQ => FactureDetails.Sum(fd => fd.TVQ);

        public float NbItems => FactureDetails.Sum(fd => fd.Quantity);

        public List<FactureDetail> FactureDetails { get; set; }
    }
}
