﻿using Fil_rouge_evente.Metier;
using Fil_rouge_evente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fil_rouge_evente.Dao
{
    public interface IDAO
    {
        Client creationCompteClient(Client c);
        Administrateur creationCompteAdmin(Administrateur a);
        Administrateur modifierCompteAdmin(Administrateur a);
        void suppressionCompte(int UtilisateurId);
        Utilisateur afficherCompte(int UtilisateurId);
        Utilisateur connexionCompte(Utilisateur ut);
        ICollection<Utilisateur> listerComptes();

        Client modifierCompte(Client c);
        Commande creerCommande(Commande c);
        void supprimerCommande(int CommandeId);
        ICollection<Commande> listerCommandes(int UtilisateurId);
        Commande modifierCommande(Commande c);
        Commande afficherCommande(int CommandeId);

        Produit ajouterProduit(Produit p);
        void supprimerProduit(int ProduitId);
        Produit modifierProduit(Produit p);
        ICollection<Produit> listerProduits();
        Produit afficherProduit(int ProduitId);
        //Utilisateur modifierUtilisateur(Utilisateur u);
        ICollection<Utilisateur> listerAdministrateur();
        ICollection<Utilisateur> rechercherUtilisateurByName(string name);
        Utilisateur rechercherUtilisateurById(int utilisateurId);
        ICollection<Utilisateur> listerClient();
        
        Catalogue ajouterCatalogue(Catalogue c);
        void supprimerCatalogue(int CatalogueId);
        Catalogue afficherCatalogue(int CatalogueId);
        ICollection<Catalogue> listerCatalogue();

        ICollection<Produit> rechercherProduitById(int id);
        ICollection<Produit> rechercherProduitsByName(string Nom);
        ICollection<Produit> rechercherProduits(decimal PrixMin, decimal PrixMax);
        ICollection<Produit> rechercherProduitsByCategorie(string Categorie);

        Promotion creerPromotion(Promotion p);
        void supprimerPromotion(int PromotionId);
        Promotion modifierPromotion(Promotion p);
        Promotion afficherPromotion(int PromotionId);
        ICollection<Promotion> listerPromotions();
        ICollection<PromotionProduit> afficherPromotionProduit();

        Avis_ClientProduit ajouterAvis(Avis_ClientProduit comm);
        Avis_ClientProduit afficherAvis(int UtilisateurId, int ProduitId);
        Avis_ClientProduit modifierAvis(Avis_ClientProduit comm);
        void supprimerAvis(int UtilisateurId, int ProduitId);
        

        Adresse ajouterAdresse(Adresse a);
        void supprimerAdresse(int AdresseId);
        Adresse afficherAdresse(int AdresseId);
        Adresse modifierAdresse(Adresse a);
        ICollection<Adresse> listerAdresse(int UtilisateurId);
        

        Abonnement creerAbonnement(Abonnement a);
        void supprimerAbonnement(int AbonnementId);
        Abonnement afficherAbonnement(int AbonnementId);
        Abonnement modifierAbonnement(Abonnement a);
        ICollection<Abonnement> listerAbonnement(int UtilisateurId);       //pour un client particulier
        ICollection<Abonnement> listerTousAbonnements();
        AbonnementClient ajouterAbonnementClient(AbonnementClient ac);
        void supprimerAbonnementClient(int AbonnementId, int UtilisateurId);
        

        Role ajouterRole(Role r);
        ICollection<Role> listerRoles();
        ICollection<Role> getRole(Utilisateur u);

        AdresseClient ajouterAdresseClient(int AdresseId, int UtilisateurId);
        ICollection<AdresseClientModel> listerAdresseClient();

        ProduitCommande ajouterLigneCommande(ProduitCommande p);
        void supprimerLigneCommande(int ProduitId, int CommandeId);
        ProduitCommande modifierLigneCommande(ProduitCommande p);
        
        Panier ajouterPanier(Panier p);
        void supprimerPanier(int PanierId);
        Panier afficherPanier(int PanierId);

        ICollection<ProduitCatalogueModel> listerProduitCatalogue();
        Anniversaire ajouterAnniversaire(Anniversaire a);
        ICollection<Anniversaire> listerAnniversaires();
        void supprimerAnniversaire(int AnniversaireId);
        Anniversaire modifierAnniversaire(Anniversaire a);
        Anniversaire afficherAnniversaire(int AnniversaireId);

        Fidelite ajouterFidelite(Fidelite f);
        void supprimerFidelite(int FideliteId);
        Fidelite modifierFidelite(Fidelite f);
        Fidelite afficherFidelite(int FideliteId);
        ICollection<Fidelite> listerFidelite();
    }
}
