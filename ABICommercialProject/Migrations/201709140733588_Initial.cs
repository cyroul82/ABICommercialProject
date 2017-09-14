namespace ABICommercialProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Collaborateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Firstname = c.String(),
                        Picture = c.String(),
                        FonctionCollabo = c.String(),
                        Statut = c.Boolean(nullable: false),
                        Address = c.String(),
                        ZipCode = c.String(),
                        Town = c.String(),
                        Tel = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contrats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SalaireBrut = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Qualification = c.String(),
                        DateDebutContrat = c.DateTime(nullable: false),
                        StatutContrat = c.Int(nullable: false),
                        DateFinEffectif = c.DateTime(),
                        MotifCloture = c.String(),
                        Cloture = c.Boolean(nullable: false),
                        DateCloture = c.DateTime(),
                        Motif = c.String(),
                        DateFinContrat = c.DateTime(),
                        AgenceInterim = c.String(),
                        Ecole = c.String(),
                        Mission = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Collaborateur_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Collaborateurs", t => t.Collaborateur_Id)
                .Index(t => t.Collaborateur_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contrats", "Collaborateur_Id", "dbo.Collaborateurs");
            DropIndex("dbo.Contrats", new[] { "Collaborateur_Id" });
            DropTable("dbo.Contrats");
            DropTable("dbo.Collaborateurs");
        }
    }
}
