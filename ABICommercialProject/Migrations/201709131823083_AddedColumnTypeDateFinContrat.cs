namespace ABICommercialProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedColumnTypeDateFinContrat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contrats", "DateFinContrat", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contrats", "DateFinContrat", c => c.DateTime());
        }
    }
}
