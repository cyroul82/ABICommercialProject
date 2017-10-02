using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABIWebsite.Models
{
    public class RootObject
    {
        public string __type { get; set; }
        public bool Cloture { get; set; }
        public DateTime DateDebutContrat { get; set; }
        public DateTime? DateFinEffectif { get; set; }
        public int Id { get; set; }
        public string MotifCloture { get; set; }
        public string Qualification { get; set; }
        public double SalaireBrut { get; set; }
        public int StatutContrat { get; set; }
    }
}