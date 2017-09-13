namespace ABICommercialProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRelationCollaborateurTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Collaborateurs", "ContratActif_Id", "dbo.Contrats");
            DropIndex("dbo.Collaborateurs", new[] { "ContratActif_Id" });
            DropColumn("dbo.Collaborateurs", "ContratActif_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Collaborateurs", "ContratActif_Id", c => c.Int());
            CreateIndex("dbo.Collaborateurs", "ContratActif_Id");
            AddForeignKey("dbo.Collaborateurs", "ContratActif_Id", "dbo.Contrats", "Id");
        }
    }
}
