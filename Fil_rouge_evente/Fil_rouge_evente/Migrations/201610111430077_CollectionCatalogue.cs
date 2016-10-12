namespace Fil_rouge_evente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CollectionCatalogue : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CatalogueProduits", "Catalogue_CatalogueId", "dbo.Catalogues");
            DropForeignKey("dbo.CatalogueProduits", "Produit_ProduitId", "dbo.Produits");
            DropIndex("dbo.CatalogueProduits", new[] { "Catalogue_CatalogueId" });
            DropIndex("dbo.CatalogueProduits", new[] { "Produit_ProduitId" });
            CreateIndex("dbo.Produits", "CatalogueId");
            AddForeignKey("dbo.Produits", "CatalogueId", "dbo.Catalogues", "CatalogueId", cascadeDelete: true);
            DropTable("dbo.CatalogueProduits");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CatalogueProduits",
                c => new
                    {
                        Catalogue_CatalogueId = c.Int(nullable: false),
                        Produit_ProduitId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Catalogue_CatalogueId, t.Produit_ProduitId });
            
            DropForeignKey("dbo.Produits", "CatalogueId", "dbo.Catalogues");
            DropIndex("dbo.Produits", new[] { "CatalogueId" });
            CreateIndex("dbo.CatalogueProduits", "Produit_ProduitId");
            CreateIndex("dbo.CatalogueProduits", "Catalogue_CatalogueId");
            AddForeignKey("dbo.CatalogueProduits", "Produit_ProduitId", "dbo.Produits", "ProduitId", cascadeDelete: true);
            AddForeignKey("dbo.CatalogueProduits", "Catalogue_CatalogueId", "dbo.Catalogues", "CatalogueId", cascadeDelete: true);
        }
    }
}
