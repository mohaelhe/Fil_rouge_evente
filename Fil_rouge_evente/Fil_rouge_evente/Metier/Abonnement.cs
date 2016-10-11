﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fil_rouge_evente.Metier
{
    public class Abonnement
    {
        public int AbonnementId { get; set; }
        [Required(ErrorMessage ="Le champ 'Nom de l'abonnement' est obligatoire")]
        [Display(Name ="Nom de l'abonnement")]
        public string Nom { get; set; }
        [Required(ErrorMessage ="Le champ 'Durée' est obligatoire")]
        [Display(Name ="Durée")]
        public int Duree { get; set; }
        [Required(ErrorMessage ="Le champ 'Prix' est obligatoire")]
        [Display(Name ="Prix")]
        [Column("Prix", TypeName = "money")]
        public decimal Prix { get; set; }

        public virtual ICollection<AbonnementClient> abonnementClients { get; set; }
    }
}