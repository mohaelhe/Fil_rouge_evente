using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fil_rouge_evente.Metier
{
    public class MoyenPaiement
    {
        public int MoyenPaiementId { get; set; }
        public enum TypePaiement { Cheque, CarteBancaire, Facture, Virement };
        public TypePaiement typePaiement { get; set; }

        public int UtilisateurId { get; set; }
        public virtual Client client { get; set; }
    }
}