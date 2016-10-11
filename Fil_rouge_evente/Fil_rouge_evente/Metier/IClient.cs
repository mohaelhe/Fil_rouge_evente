using Fil_rouge_evente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fil_rouge_evente.Metier
{
    public interface IClient: IUtilisateur
    {
        ICollection<Produit> rechercherProduits(decimal PrixMin, decimal PrixMax);
        ICollection<Produit> rechercherProduitsByCategorie(string Categorie);
        Commande creerCommande(Commande c);
        Commande modifierCommande(Commande c);
        void supprimerCommande(int CommandeId);
        ICollection<Commande> listerCommandes(int UtilisateurId);
        Commande afficherCommande(int CommandeId);
        ICollection<Abonnement> listerTousAbonnements();
        AbonnementClient ajouterAbonnementClient(AbonnementClient ac);
        ICollection<Abonnement> listerAbonnement(int UtilisateurId);
        ProduitCommande ajouterLigneCommande(ProduitCommande p);
        void supprimerLigneCommande(int ProduitId, int CommandeId);
        ProduitCommande modifierLigneCommande(ProduitCommande p);
        Panier ajouterPanier(Panier p);
        void supprimerPanier(int PanierId);
        Panier afficherPanier(int PanierId);
        ICollection<Promotion> listerPromotions();
        Client creationCompteClient(Client c);
        Client modifierCompte(Client c);
        Adresse ajouterAdresse(Adresse a);
        void supprimerAdresse(int AdresseId);
        ICollection<Adresse> listerAdresse(int UtilisateurId);
        AdresseClient ajouterAdresseClient(int AdresseId, int UtilisateurId);
        Adresse modifierAdresse(Adresse a);
        Adresse afficherAdresse(int AdresseId);

    }
}
