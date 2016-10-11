using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fil_rouge_evente.Metier
{
    public class Adresse
    {
        public int AdresseId { get; set; }
        public string NumeroRue { get; set; }
        public string NomRue { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public enum TypeAdresse { Livraison, Facturation };
        public TypeAdresse typeadresse { get; set; }

        public virtual ICollection<AdresseClient> adresseClients { get; set; }
    }
}