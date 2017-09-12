namespace ABICommercialProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDateTimeToDateTime2ContratTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contrats", "DateFinEffectif", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contrats", "DateFinEffectif", c => c.DateTime());
        }
    }
}
