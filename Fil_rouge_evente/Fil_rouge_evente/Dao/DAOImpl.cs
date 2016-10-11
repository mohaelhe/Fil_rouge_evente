using Fil_rouge_evente.Metier;
using Fil_rouge_evente.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fil_rouge_evente.Dao
{
    public class DAOImpl: IDAO
    {
        public Client creationCompteClient(Client c)
        {
            using(var db = new Dao.ProjetContext())
            {
                c.RoleId = 1;
                c.NombrePoints = 0;
                c.CompteASupprimer = false;
                c.Actif = true;
                db.utilisateurs.Add(c);

                db.SaveChanges();
                return c;
            }
        }

        public Administrateur creationCompteAdmin(Administrateur a)
        {
            using (var db = new Dao.ProjetContext())
            {
                Role r = new Role();
                r.Droit = 2;       // 2 choix pour l'administrateur

                db.roles.Add(r);
                db.SaveChanges();

                a.RoleId = r.RoleId;

                db.utilisateurs.Add(a);
                db.SaveChanges();
                return a;
            }
        }

        public void suppressionCompte(int UtilisateurId)
        {
            using (var db = new Dao.ProjetContext())
            {
                var res = db.utilisateurs.Find(UtilisateurId);
                db.utilisateurs.Remove(res);
                db.SaveChanges();
            }
        }

        public Utilisateur afficherCompte(int UtilisateurId)
        {
            using (var db = new Dao.ProjetContext())
            {
                return db.utilisateurs.Find(UtilisateurId);
            }
        }

        public Commande creerCommande(Commande c)
        {
            using (var db = new Dao.ProjetContext())
            {
                db.commandes.Add(c);
                db.SaveChanges();
                return c;
            }
        }

        public void supprimerCommande(int CommandeId)
        {
            using (var db = new Dao.ProjetContext())
            {
                var res = db.commandes.Find(CommandeId);
                db.commandes.Remove(res);
                db.SaveChanges();
            }
        }

        public Produit ajouterProduit(Produit p)
        {
            using (var db = new Dao.ProjetContext())
            {
                db.produits.Add(p);
                db.SaveChanges();
                return p;
            }
        }

        public void supprimerProduit(int ProduitId)
        {
            using (var db = new Dao.ProjetContext())
            {
                var res = db.produits.Find(ProduitId);
                db.produits.Remove(res);
                db.SaveChanges();
            }
        }

        public Catalogue ajouterCatalogue(Catalogue c)
        {
            using (var db = new Dao.ProjetContext())
            {
                db.catalogues.Add(c);
                db.SaveChanges();
                return c;
            }
        }

        public void supprimerCatalogue(int CatalogueId)
        {
            using (var db = new Dao.ProjetContext())
            {
                var res = db.catalogues.Find(CatalogueId);
                db.catalogues.Remove(res);
                db.SaveChanges();
            }
        }

        public Catalogue afficherCatalogue(int CatalogueId)
        {
            using (var db = new Dao.ProjetContext())
            {
                return db.catalogues.Find(CatalogueId);
            }
        }

        public ICollection<Produit> rechercherProduitsByName(string Nom)
        {
            using (var db = new Dao.ProjetContext())
            {
                var res = from p in db.produits
                          where p.Nom.Contains(Nom)
                          select p;

                return res.ToList();
            }
        }

        public ICollection<Produit> rechercherProduits(decimal prixMin, decimal prixMax)
        {
            using (var db = new Dao.ProjetContext())
            {
                var res = from p in db.produits
                          where p.Prix >= prixMin && p.Prix <= prixMax
                          select p;

                return res.ToList();
            }
        }

        public ICollection<Produit> rechercherProduitsByCategorie(string Categorie)
        {
            using (var db = new Dao.ProjetContext())
            {
                var res = from p in db.produits
                          where p.Categorie == Categorie
                          select p;
                return res.ToList();
            }
        }

        public Promotion creerPromotion(Promotion p)
        {
            using (var db = new Dao.ProjetContext())
            {
                db.promotions.Add(p);
                db.SaveChanges();
                return p;
            }
        }

        public void supprimerPromotion(int PromotionId)
        {
            using (var db = new Dao.ProjetContext())
            {
                var res = db.promotions.Find(PromotionId);
                db.promotions.Remove(res);
                db.SaveChanges();
            }
        }

        public Avis_ClientProduit ajouterAvis(Avis_ClientProduit comm)
        {
            using(var db = new Dao.ProjetContext())
            {
                db.avis_clientProduits.Add(comm);
                db.SaveChanges();
                return comm;
            }
        }

        public Adresse ajouterAdresse(Adresse a)
        {
            using (var db = new Dao.ProjetContext())
            {
                db.adresses.Add(a);
                db.SaveChanges();
                return a;
            }
        }

        public void supprimerAdresse(int AdresseId)
        {
            using (var db = new Dao.ProjetContext())
            {
                var res = db.adresses.Find(AdresseId);
                db.adresses.Remove(res);
                db.SaveChanges();
            }
        }

        public Abonnement ajouterAbonnement(Abonnement a)
        {
            using (var db = new Dao.ProjetContext())
            {
                db.abonnements.Add(a);
                db.SaveChanges();
                return a;
            }
        }

        public void supprimerAbonnement(int AbonnementId)
        {
            using (var db = new Dao.ProjetContext())
            {
                var res = db.abonnements.Find(AbonnementId);
                db.abonnements.Remove(res);
                db.SaveChanges();
            }
        }

        public Role ajouterRole(Role r)
        {
            using (var db = new Dao.ProjetContext())
            {
                db.roles.Add(r);
                db.SaveChanges();
                return r;
            }
        }

        public AdresseClient ajouterAdresseClient(int AdresseId, int UtilisateurId)
        {
            using (var db = new Dao.ProjetContext())
            {
                var a = new AdresseClient();
                a.AdresseId = AdresseId;
                a.UtilisateurId = UtilisateurId;
                db.adresseClients.Add(a);
                db.SaveChanges();
                return a;
            }
        }

        public ICollection<Commande> listerCommandes(int UtilisateurId)
        {
            using (var db = new Dao.ProjetContext())
            {
                var res = from c in db.commandes
                          where c.UtilisateurId == UtilisateurId
                          select c;
                return res.ToList();

            }
        }

        public Adresse afficherAdresse(int AdresseId)
        {
            using (var db = new Dao.ProjetContext())
            {
                return db.adresses.Find(AdresseId);
            }
        }

        public Adresse modifierAdresse(Adresse a)
        {
            using (var db = new Dao.ProjetContext())
            {
                db.Entry(a).State = EntityState.Modified;
                db.SaveChanges();
                return a;
            }
        }

        public Client modifierCompte(Client c)
        {
            using (var db = new Dao.ProjetContext())
            {
                
                db.Entry(c).State = EntityState.Modified;
                db.SaveChanges();
                return c;
            }
        }

        public Commande modifierCommande(Commande c)
        {
            using (var db = new Dao.ProjetContext())
            {
                db.Entry(c).State = EntityState.Modified;
                db.SaveChanges();
                return c;
            }
        }

        public Produit modifierProduit(Produit p)
        {
            using (var db = new Dao.ProjetContext())
            {
                db.Entry(p).State = EntityState.Modified;
                db.SaveChanges();
                return p;
            }
        }

        public ICollection<Produit> listerProduits()
        {
            using (var db = new Dao.ProjetContext())
            {
                return db.produits.ToList();
            }
        }

        public Produit afficherProduit(int ProduitId)
        {
            using (var db = new Dao.ProjetContext())
            {
                return db.produits.Find(ProduitId);
            }
        }
     
        //public Utilisateur modifierUtilisateur(Utilisateur u)
        //{
        //    using (var db = new Dao.ProjetContext())
        //    {
        //        db.Entry(u).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return u;
        //    }
        //}

        public ICollection<Utilisateur> rechercherUtilisateurByName(string name)
        {
            using (var db = new Dao.ProjetContext())
            {
                var res = from u in db.utilisateurs
                          where u.Nom.Contains(name)
                          select u;

                return res.ToList();
            }
        }

        public Utilisateur rechercherUtilisateurById(int UtilisateurId)
        {
            using (var db = new Dao.ProjetContext())
            {
                return db.utilisateurs.Find(UtilisateurId);
            }
        }

        public ICollection<Utilisateur> listerClient()
        {
            using (var db = new Dao.ProjetContext())
            {
                var res = from c in db.utilisateurs
                          where c.RoleId == 2
                          select c;

                return res.ToList();
            }
        }

        public ICollection<Utilisateur> listerAdministrateur()
        {
            using (var db = new Dao.ProjetContext())
            {
                var res = from c in db.utilisateurs
                          where c.RoleId == 1
                          select c;

                return res.ToList();
            }
        }
        

        public Promotion modifierPromotion(Promotion p)
        {
            using (var db = new Dao.ProjetContext())
            {
                db.Entry(p).State = EntityState.Modified;
                db.SaveChanges();
                return p;
            }
        }

        public ProduitCommande ajouterLigneCommande(ProduitCommande p)
        {
            using (var db = new Dao.ProjetContext())
            {
                db.produitCommandes.Add(p);
                db.SaveChanges();
                return p;
            }
        }

        public void supprimerLigneCommande(int ProduitId, int CommandeId)
        {
            using (var db = new Dao.ProjetContext())
            {
                var res = db.produitCommandes.Find(ProduitId, CommandeId);
                db.produitCommandes.Remove(res);
                db.SaveChanges();
            }
        }

        public ProduitCommande modifierLigneCommande(ProduitCommande p)
        {
            using (var db = new Dao.ProjetContext())
            {
                db.Entry(p).State = EntityState.Modified;
                db.SaveChanges();
                return p;
            }
        }

        public Panier ajouterPanier(Panier p)
        {
            using (var db = new Dao.ProjetContext())
            {
                db.paniers.Add(p);
                db.SaveChanges();
                return p;
            }
        }

        public void supprimerPanier(int PanierId)
        {
            using (var db = new Dao.ProjetContext())
            {
                var res = db.paniers.Find(PanierId);
                db.paniers.Remove(res);
                db.SaveChanges();
            }
        }

        public Panier afficherPanier(int PanierId)
        {
            using (var db = new Dao.ProjetContext())
            {
                return db.paniers.Find(PanierId);
            }
        }
        

        //Peut-être nécessité de faire un model pour afficher également le login du client
        public Avis_ClientProduit afficherAvis(int UtilisateurId, int ProduitId)
        {
            using (var db = new Dao.ProjetContext())
            {
                var res = from dp in db.avis_clientProduits
                          where dp.UtilisateurId == UtilisateurId && dp.ProduitId == ProduitId
                          select dp;

                return res.ToList()[0];
            }
        }

        public void supprimerAvis(int UtilisateurId, int ProduitId)
        {
            using (var db = new ProjetContext())
            {
                var res = db.avis_clientProduits.Find(UtilisateurId, ProduitId);
                db.avis_clientProduits.Remove(res);
                db.SaveChanges();
            }
        }

        public Abonnement creerAbonnement(Abonnement a)
        {
            using (var db = new Dao.ProjetContext())
            {
                
                
                    db.abonnements.Add(a);
                    db.SaveChanges();
                    return a;
                
            }
        }

        public Abonnement afficherAbonnement(int AbonnementId)
        {
            using (var db = new Dao.ProjetContext())
            {
                return db.abonnements.Find(AbonnementId);
            }
        }

        public Commande afficherCommande(int CommandeId)
        {
            using (var db = new ProjetContext())
            {
                return db.commandes.Find(CommandeId);
            }
        }

        public Promotion afficherPromotion(int PromotionId)
        {
            using (var db = new ProjetContext())
            {
                return db.promotions.Find(PromotionId);
            }
        }

        public Avis_ClientProduit modifierAvis(Avis_ClientProduit comm)
        {
            using (var db = new ProjetContext())
            {
                db.Entry(comm).State = EntityState.Modified;
                db.SaveChanges();
                return comm;
            }
        }

        public ICollection<Adresse> listerAdresse(int UtilisateurId)
        {
            using (var db = new ProjetContext())
            {
                var res = from a in db.adresses
                          join ac in db.adresseClients on a.AdresseId equals ac.AdresseId
                          where ac.UtilisateurId == UtilisateurId
                          select a;

                return res.ToList();
            }
        }

        public ICollection<AdresseClientModel> listerAdresseClient()
        {
            using (var db = new ProjetContext())
            {
                var res = from ac in db.adresseClients
                          join a in db.adresses on ac.AdresseId equals a.AdresseId
                          join u in db.utilisateurs on ac.UtilisateurId equals u.UtilisateurId
                          select new AdresseClientModel
                          {
                              Nom = u.Nom,
                              Prenom = u.Prenom,
                              NumeroRue = a.NumeroRue,
                              NomRue = a.NomRue,
                              CodePostal = a.CodePostal,
                              Ville = a.Ville
                          };

                return res.ToList();
            }
        }

        public ICollection<Abonnement> listerAbonnement(int UtilisateurId)
        {
            using (var db = new ProjetContext())
            {
                var res = from a in db.abonnements
                          join ac in db.abonnementClients on a.AbonnementId equals ac.AbonnementId
                          where ac.UtilisateurId == UtilisateurId
                          select a;

                return res.ToList();
            }
        }

        public AbonnementClient ajouterAbonnementClient(AbonnementClient ac)
        {
            using (var db = new ProjetContext())
            {
                db.abonnementClients.Add(ac);
                db.SaveChanges();
                return ac;
            }
        }

        public ICollection<Abonnement> listerTousAbonnements()
        {
            using (var db = new ProjetContext())
            {
                return db.abonnements.ToList();
            }
        }

        public void supprimerAbonnementClient(int AbonnementId, int UtilisateurId)
        {
            using (var db = new ProjetContext())
            {
                var res = db.abonnementClients.Find(AbonnementId, UtilisateurId);
                db.abonnementClients.Remove(res);
                db.SaveChanges();
            }
        }

        public ICollection<Promotion> listerPromotions()
        {
            using (var db = new ProjetContext())
            {
               
                return db.promotions.ToList();
            }
        }

        public Utilisateur connexionCompte(Utilisateur ut)
        {

            using (var db = new ProjetContext())
            {
                var usr = from u in db.utilisateurs
                          where u.login == ut.login && u.password == ut.password
                          select u;

                return usr.FirstOrDefault();
            }
        }

        public ICollection<Catalogue> listerCatalogue()
        {
            using (var db = new ProjetContext())
            {
                return db.catalogues.ToList();
            }
        }

        public ICollection<ProduitCatalogueModel> listerProduitCatalogue()
        {
            using (var db = new ProjetContext())
            {
                var req = from p in db.produits
                          join c in db.catalogues on p.CatalogueId equals c.CatalogueId
                          select new ProduitCatalogueModel
                          {
                              ProduitId = p.ProduitId,
                              NomProduit = p.Nom,
                              Prix = p.Prix,
                              Stock = p.Stock,
                              Categorie = p.Categorie,
                              NomCatalogue = c.Nom
                          };
                return req.ToList();
            }
        }

        public ICollection<Produit> rechercherProduitById(int id)
        {
            using (var db = new ProjetContext())
            {
                var res = from p in db.produits
                          where p.ProduitId == id
                          select p;
                return res.ToList();
            }
        }

        public ICollection<Role> listerRoles()
        {
            using (var db = new ProjetContext())
            {
                return db.roles.ToList();
            }
        }

        public ICollection<Utilisateur> listerComptes()
        {
            using (var db = new ProjetContext())
            {
                return db.utilisateurs.ToList();
            }
        }

        public Abonnement modifierAbonnement(Abonnement a)
        {
            using (var db = new ProjetContext())
            {
                db.Entry(a).State = EntityState.Modified;
                db.SaveChanges();
                return a;
            }
        }

        public ICollection<PromotionProduit> afficherPromotionProduit()
        {
            using (var db = new ProjetContext())
            {
                var res = from p1 in db.promotions
                          join p2 in db.produits on p1.ProduitId equals p2.ProduitId
                          select new PromotionProduit
                          {                              
                              Remise = p1.Remise,
                              ProduitId = p2.ProduitId,
                              ProduitNom = p2.Nom,
                              Prix = p2.Prix
                          };

                return res.ToList();
            }
        }

        public Administrateur modifierCompteAdmin(Administrateur a)
        {
            using (var db = new ProjetContext())
            {
                db.Entry(a).State = EntityState.Modified;
                db.SaveChanges();
                return a;
            }
        }

        public Anniversaire ajouterAnniversaire(Anniversaire a)
        {
            using (var db = new ProjetContext())
            {
                db.anniversaires.Add(a);
                db.SaveChanges();
                return a;
            }
        }

        public ICollection<Anniversaire> listerAnniversaires()
        {
            using (var db = new ProjetContext())
            {
                return db.anniversaires.ToList();
            }
        }

        public void supprimerAnniversaire(int AnniversaireId)
        {
            using (var db = new ProjetContext())
            {
                var res = db.anniversaires.Find(AnniversaireId);
                db.anniversaires.Remove(res);
                db.SaveChanges();
            }
        }

        public Anniversaire modifierAnniversaire(Anniversaire a)
        {
            using (var db = new ProjetContext())
            {
                db.Entry(a).State = EntityState.Modified;
                db.SaveChanges();
                return a;
            }
        }

        public Anniversaire afficherAnniversaire(int AnniversaireId)
        {
            using (var db = new ProjetContext())
            {
                return db.anniversaires.Find(AnniversaireId);
            }
        }

        public Fidelite ajouterFidelite(Fidelite f)
        {
            using (var db = new ProjetContext())
            {
                db.fidelites.Add(f);
                db.SaveChanges();
                return f;
            }
        }

        public void supprimerFidelite(int FideliteId)
        {
            using (var db = new ProjetContext())
            {
                var res = db.fidelites.Find(FideliteId);
                db.fidelites.Remove(res);
                db.SaveChanges();
            }
        }

        public Fidelite modifierFidelite(Fidelite f)
        {
            using (var db = new ProjetContext())
            {
                db.Entry(f).State = EntityState.Modified;
                db.SaveChanges();
                return f;
            }
        }

        public Fidelite afficherFidelite(int FideliteId)
        {
            using (var db = new ProjetContext())
            {
                return db.fidelites.Find(FideliteId);
            }
        }

        public ICollection<Fidelite> listerFidelite()
        {
            using (var db = new ProjetContext())
            {
                return db.fidelites.ToList();
            }
        }

        public ICollection<Role> getRole(Utilisateur u)
        {
            using (var edb = new ProjetContext())
            {
                var req = from r in edb.roles
                          where (u.RoleId == r.RoleId)
                          select r;
                return req.ToList();
            }
        }
    }
}