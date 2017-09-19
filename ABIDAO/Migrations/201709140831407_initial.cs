namespace ABIDAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Collaborateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Firstname = c.String(nullable: false, maxLength: 50),
                        Picture = c.String(),
                        FonctionCollabo = c.String(),
                        Statut = c.Boolean(nullable: false),
                        Address = c.String(),
                        ZipCode = c.String(maxLength: 5),
                        Town = c.String(),
                        Tel = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => new { t.Name, t.Firstname }, unique: true, name: "IX_NameFirstname");
            
            CreateTable(
                "dbo.Contrats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SalaireBrut = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Qualification = c.String(maxLength: 200),
                        DateDebutContrat = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        StatutContrat = c.Int(nullable: false),
                        DateFinEffectif = c.DateTime(precision: 7, storeType: "datetime2"),
                        MotifCloture = c.String(),
                        Cloture = c.Boolean(nullable: false),
                        DateCloture = c.DateTime(precision: 7, storeType: "datetime2"),
                        Motif = c.String(),
                        DateFinContrat = c.DateTime(precision: 7, storeType: "datetime2"),
                        AgenceInterim = c.String(),
                        Ecole = c.String(),
                        Mission = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Collaborateur_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Collaborateurs", t => t.Collaborateur_Id)
                .Index(t => t.Collaborateur_Id);
            
            CreateTable(
                "dbo.AugmentationSalaires",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Taux = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Collaborateur_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Collaborateurs", t => t.Collaborateur_Id)
                .Index(t => t.Collaborateur_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AugmentationSalaires", "Collaborateur_Id", "dbo.Collaborateurs");
            DropForeignKey("dbo.Contrats", "Collaborateur_Id", "dbo.Collaborateurs");
            DropIndex("dbo.AugmentationSalaires", new[] { "Collaborateur_Id" });
            DropIndex("dbo.Contrats", new[] { "Collaborateur_Id" });
            DropIndex("dbo.Collaborateurs", "IX_NameFirstname");
            DropTable("dbo.AugmentationSalaires");
            DropTable("dbo.Contrats");
            DropTable("dbo.Collaborateurs");
        }
    }
}
