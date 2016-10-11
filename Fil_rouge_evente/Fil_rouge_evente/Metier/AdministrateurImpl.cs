using Fil_rouge_evente.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fil_rouge_evente.Models;

namespace Fil_rouge_evente.Metier
{
    public class AdministrateurImpl: IAdministrateur
    {
        IDAO idao = new DAOImpl();

        public void suppressionCompte(int UtilisateurId)
        {
            idao.suppressionCompte(UtilisateurId);
        }

        public Produit ajouterProduit(Produit p)
        {
            return idao.ajouterProduit(p);
        }

        public void supprimerProduit(int ProduitId)
        {
            idao.supprimerProduit(ProduitId);
        }

        public Produit modifierProduit(Produit p)
        {
            return idao.modifierProduit(p);
        }

        public Administrateur creationCompteAdmin(Administrateur a)
        {
            return idao.creationCompteAdmin(a);
        }

        public Utilisateur afficherCompte(int UtilisateurId)
        {
            return idao.afficherCompte(UtilisateurId);
        }

        public Role ajouterRole(Role r)
        {
            return idao.ajouterRole(r);
        }

        public ICollection<AdresseClientModel> listerAdresseClient()
        {
            return idao.listerAdresseClient();
        }

        public Promotion creerPromotion(Promotion p)
        {
            return idao.creerPromotion(p);
        }

        public void supprimerPromotion(int PromotionId)
        {
            idao.supprimerPromotion(PromotionId);
        }

        public Promotion modifierPromotion(Promotion p)
        {
            return idao.modifierPromotion(p);
        }

        public ICollection<Produit> listerProduits()
        {
            return idao.listerProduits();
        }

        public Catalogue ajouterCatalogue(Catalogue c)
        {
            return idao.ajouterCatalogue(c);
        }

        public void supprimerCatalogue(int CatalogueId)
        {
            idao.supprimerCatalogue(CatalogueId);
        }

        public ICollection<Catalogue> listerCatalogue()
        {
            return idao.listerCatalogue();
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

        public ICollection<Produit> rechercherProduitById(int id)
        {
            return idao.rechercherProduitById(id);
        }

        public ICollection<Role> listerRoles()
        {
            return idao.listerRoles();
        }

        public ICollection<Utilisateur> listerComptes()
        {
            return idao.listerComptes();
        }
        public Utilisateur connexionCompte(Utilisateur ut)
        {
            return idao.connexionCompte(ut);
        }

        public Abonnement creerAbonnement(Abonnement a)
        {
            return idao.creerAbonnement(a);
        }

        public void supprimerAbonnement(int AbonnementId)
        {
            idao.supprimerAbonnement(AbonnementId);
        }

        public ICollection<Abonnement> listerTousAbonnements()
        {
            return idao.listerTousAbonnements();
        }

        public Abonnement modifierAbonnement(Abonnement a)
        {
            return idao.modifierAbonnement(a);
        }

        public Abonnement afficherAbonnement(int AbonnementId)
        {
            return idao.afficherAbonnement(AbonnementId);
        }

        public ICollection<PromotionProduit> afficherPromotionProduit()
        {
            return idao.afficherPromotionProduit();
        }

        public Administrateur modifierCompteAdmin(Administrateur a)
        {
            return idao.modifierCompteAdmin(a);
        }

        public Anniversaire ajouterAnniversaire(Anniversaire a)
        {
            return idao.ajouterAnniversaire(a);
        }

        public ICollection<Anniversaire> listerAnniversaires()
        {
            return idao.listerAnniversaires();
        }

        public void supprimerAnniversaire(int AnniversaireId)
        {
            idao.supprimerAnniversaire(AnniversaireId);
        }

        public Anniversaire modifierAnniversaire(Anniversaire a)
        {
            return idao.modifierAnniversaire(a);
        }

        public Anniversaire afficherAnniversaire(int AnniversaireId)
        {
            return idao.afficherAnniversaire(AnniversaireId);
        }

        public Fidelite ajouterFidelite(Fidelite f)
        {
            return idao.ajouterFidelite(f);
        }

        public void supprimerFidelite(int FideliteId)
        {
            supprimerFidelite(FideliteId);
        }

        public Fidelite modifierFidelite(Fidelite f)
        {
            return idao.modifierFidelite(f);
        }

        public ICollection<Fidelite> listerFidelite()
        {
            return idao.listerFidelite();
        }

        public Fidelite afficherFidelite(int FideliteId)
        {
            return idao.afficherFidelite(FideliteId);
        }

        public ICollection<Role> getRole(Utilisateur u)
        {
            return idao.getRole(u);
        }
    }
}