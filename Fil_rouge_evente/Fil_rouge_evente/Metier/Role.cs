using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fil_rouge_evente.Metier
{
    public class Role
    {
        public int RoleId { get; set; }
        public string nomRole { get; set; }

        public virtual ICollection<Utilisateur> utilisateurs { get; set; }
    }
}