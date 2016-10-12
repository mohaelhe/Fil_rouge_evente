namespace Fil_rouge_evente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateadmin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "Droit", c => c.Int(nullable: false));
            DropColumn("dbo.Roles", "nomRole");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "nomRole", c => c.String());
            DropColumn("dbo.Roles", "Droit");
        }
    }
}
