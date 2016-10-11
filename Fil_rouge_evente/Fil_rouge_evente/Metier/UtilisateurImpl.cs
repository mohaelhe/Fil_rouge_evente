using Fil_rouge_evente.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fil_rouge_evente.Models;

namespace Fil_rouge_evente.Metier
{
    public class UtilisateurImpl : IUtilisateur
    {
        IDAO idao = new DAOImpl();
        public Utilisateur afficherCompte(int UtilisateurId)
        {
            return idao.afficherCompte(UtilisateurId);
        }

        public ICollection<Produit> listerProduits()
        {
            return idao.listerProduits();
        }

        public ICollection<ProduitCatalogueModel> listerProduitCatalogue()
        {
            return idao.listerProduitCatalogue();
        }

        public Produit afficherProduit(int ProduitId)
        {
            return idao.afficherProduit(ProduitId);
        }

        public ICollection<Produit> rechercherProduitsByName(string Nom)
        {
            return idao.rechercherProduitsByName(Nom);
        }


        public Utilisateur connexionCompte(Utilisateur ut)
        {
            return idao.connexionCompte(ut);
        }

        public ICollection<PromotionProduit> afficherPromotionProduit()
        {
            return idao.afficherPromotionProduit();
        }

        public Anniversaire afficherAnniversaire(int AnniversaireId)
        {
            return idao.afficherAnniversaire(AnniversaireId);
        }

        public Fidelite afficherFidelite(int FideliteId)
        {
            return idao.afficherFidelite(FideliteId);
        }
    }
}