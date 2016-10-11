using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fil_rouge_evente.Metier
{
    public class Utilisateur
    {
        public int UtilisateurId { get; set; }
        [Required(ErrorMessage ="Le champ NOM est obligatoire")]
        [Display(Name ="Nom de l'utilisateur")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Le champ PRENOM est obligatoire")]
        [Display(Name ="Prénom")]
        public string Prenom { get; set; }
        [Required(ErrorMessage = "Le champ EMAIL est obligatoire")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Ce champ doit contenir un Email valide")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Le champ LOGIN est obligatoire")]
        [Display(Name ="Login")]
        public string login { get; set; }
        [Required(ErrorMessage = "Le champ PASSWORD est obligatoire")]
        [Display(Name ="Mot de passe")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required(ErrorMessage = "Le champ CONFIRMATION est obligatoire")]
        [Display(Name = "Confirmation du mot de passe")]
        [Compare("password", ErrorMessage = "Confirmez votre mot de passe")]
        [DataType(DataType.Password)]
        public string confirmPassword { get; set; }

        public virtual ICollection<Historique_UtilisateurProduit> historiques_UtilisateurProduit { get; set; }
        public int RoleId { get; set; }
        public virtual Role role { get; set; }

    }
}