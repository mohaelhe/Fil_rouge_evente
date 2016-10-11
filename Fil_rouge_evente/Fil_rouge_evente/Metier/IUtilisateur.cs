using Fil_rouge_evente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fil_rouge_evente.Metier
{
    public interface IUtilisateur
    {
        Utilisateur afficherCompte(int UtilisateurId);
        ICollection<Produit> listerProduits();
        ICollection<ProduitCatalogueModel> listerProduitCatalogue();
        Produit afficherProduit(int ProduitId);
        ICollection<Produit> rechercherProduitsByName(string Nom);
        Utilisateur connexionCompte(Utilisateur ut);
        ICollection<PromotionProduit> afficherPromotionProduit();
        Anniversaire afficherAnniversaire(int AnniversaireId);
        Fidelite afficherFidelite(int FideliteId);
    }
}
