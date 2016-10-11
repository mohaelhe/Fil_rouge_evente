using Fil_rouge_evente.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fil_rouge_evente.Models;

namespace Fil_rouge_evente.Metier
{
    public class ClientImpl: IClient
    {
        IDAO idao = new DAOImpl();
        public ICollection<Produit> rechercherProduitsByName(string Nom)
        {
            return idao.rechercherProduitsByName(Nom);
        }

        public ICollection<Produit> rechercherProduits(decimal PrixMin, decimal PrixMax)
        {
            return idao.rechercherProduits(PrixMin, PrixMax);
        }

        public ICollection<Produit> rechercherProduitsByCategorie(string Categorie)
        {
            return idao.rechercherProduitsByCategorie(Categorie);
        }

        public Client creationCompteClient(Client c)
        {

            return idao.creationCompteClient(c);
        }

        public Utilisateur afficherCompte(int UtilisateurId)
        {
            return idao.afficherCompte(UtilisateurId);
        }

        public Commande creerCommande(Commande c)
        {
            return idao.creerCommande(c);
        }

        public Commande modifierCommande(Commande c)
        {
            return idao.modifierCommande(c);
        }

        public void supprimerCommande(int CommandeId)
        {
            idao.supprimerCommande(CommandeId);
        }

        public ICollection<Commande> listerCommandes(int UtilisateurId)
        {
            return idao.listerCommandes(UtilisateurId);
        }

        public Commande afficherCommande(int CommandeId)
        {
            return idao.afficherCommande(CommandeId);
        }

        public ICollection<Abonnement> listerTousAbonnements()
        {
            return idao.listerTousAbonnements();
        }

        public AbonnementClient ajouterAbonnementClient(AbonnementClient ac)
        {
            return idao.ajouterAbonnementClient(ac);
        }

        public ICollection<Abonnement> listerAbonnement(int UtilisateurId)
        {
            return idao.listerAbonnement(UtilisateurId);
        }

        public AdresseClient ajouterAdresseClient(int AdresseId, int UtilisateurId)
        {
            return idao.ajouterAdresseClient(AdresseId, UtilisateurId);
        }

        public ProduitCommande ajouterLigneCommande(ProduitCommande p)
        {
            return idao.ajouterLigneCommande(p);
        }

        public void supprimerLigneCommande(int ProduitId, int CommandeId)
        {
            idao.supprimerLigneCommande(ProduitId, CommandeId);
        }

        public ProduitCommande modifierLigneCommande(ProduitCommande p)
        {
            return idao.modifierLigneCommande(p);
        }

        public Panier ajouterPanier(Panier p)
        {
            return idao.ajouterPanier(p);
        }

        public void supprimerPanier(int PanierId)
        {
            idao.supprimerPanier(PanierId);
        }

        public Panier afficherPanier(int PanierId)
        {
            return idao.afficherPanier(PanierId);
        }

        public ICollection<Promotion> listerPromotions()
        {
            return idao.listerPromotions();
        }

        public Utilisateur connexionCompte(Utilisateur ut)
        {
            return idao.connexionCompte(ut);
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

        public Client modifierCompte(Client c)
        {
            return idao.modifierCompte(c);
        }

        public Adresse ajouterAdresse(Adresse a)
        {
            return idao.ajouterAdresse(a);
        }

        public void supprimerAdresse(int AdresseId)
        {
            idao.supprimerAdresse(AdresseId);
        }

        public ICollection<Adresse> listerAdresse(int UtilisateurId)
        {
            return idao.listerAdresse(UtilisateurId);
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
        
        public Adresse modifierAdresse(Adresse a)
        {
            return idao.modifierAdresse(a);
        }


        public Adresse afficherAdresse(int AdresseId)
        {
            return idao.afficherAdresse(AdresseId);
        }
    }
}