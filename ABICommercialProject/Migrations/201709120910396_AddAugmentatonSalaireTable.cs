namespace ABICommercialProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAugmentatonSalaireTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AugmentationSalaires",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Taux = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Collaborateur_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Collaborateurs", t => t.Collaborateur_Id)
                .Index(t => t.Collaborateur_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AugmentationSalaires", "Collaborateur_Id", "dbo.Collaborateurs");
            DropIndex("dbo.AugmentationSalaires", new[] { "Collaborateur_Id" });
            DropTable("dbo.AugmentationSalaires");
        }
    }
}
