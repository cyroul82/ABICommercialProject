namespace ABICommercialProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDateTimeTypeToContratTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contrats", "DateDebutContrat", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contrats", "DateDebutContrat", c => c.DateTime(nullable: false));
        }
    }
}
