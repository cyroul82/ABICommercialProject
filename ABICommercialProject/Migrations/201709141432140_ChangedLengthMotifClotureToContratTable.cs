namespace ABICommercialProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedLengthMotifClotureToContratTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contrats", "MotifCloture", c => c.String(maxLength: 2000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contrats", "MotifCloture", c => c.String());
        }
    }
}
