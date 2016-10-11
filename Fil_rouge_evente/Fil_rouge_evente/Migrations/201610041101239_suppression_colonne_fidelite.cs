namespace Fil_rouge_evente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class suppression_colonne_fidelite : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Fidelites", "UtilisateurId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fidelites", "UtilisateurId", c => c.Int(nullable: false));
        }
    }
}
