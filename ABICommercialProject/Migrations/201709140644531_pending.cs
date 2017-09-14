namespace ABICommercialProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pending : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Contrats", "CollaborateurID", "dbo.Collaborateurs");
            AddColumn("dbo.Contrats", "Collaborateur_Id", c => c.Int());
            CreateIndex("dbo.Contrats", "Collaborateur_Id");
            AddForeignKey("dbo.Contrats", "Collaborateur_Id", "dbo.Collaborateurs", "Id");
            AddForeignKey("dbo.Contrats", "CollaborateurID", "dbo.Collaborateurs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contrats", "CollaborateurID", "dbo.Collaborateurs");
            DropForeignKey("dbo.Contrats", "Collaborateur_Id", "dbo.Collaborateurs");
            DropIndex("dbo.Contrats", new[] { "Collaborateur_Id" });
            DropColumn("dbo.Contrats", "Collaborateur_Id");
            AddForeignKey("dbo.Contrats", "CollaborateurID", "dbo.Collaborateurs", "Id");
        }
    }
}
