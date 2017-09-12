namespace ABICommercialProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationBetweenCollaborateurAndContratOneToMany : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Contrats", new[] { "Collaborateur_Id" });
            RenameColumn(table: "dbo.Contrats", name: "Collaborateur_Id", newName: "CollaborateurID");
            AlterColumn("dbo.Contrats", "CollaborateurID", c => c.Int(nullable: false));
            CreateIndex("dbo.Contrats", "CollaborateurID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Contrats", new[] { "CollaborateurID" });
            AlterColumn("dbo.Contrats", "CollaborateurID", c => c.Int());
            RenameColumn(table: "dbo.Contrats", name: "CollaborateurID", newName: "Collaborateur_Id");
            CreateIndex("dbo.Contrats", "Collaborateur_Id");
        }
    }
}
