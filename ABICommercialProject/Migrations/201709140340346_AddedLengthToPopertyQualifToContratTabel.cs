namespace ABICommercialProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLengthToPopertyQualifToContratTabel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contrats", "Qualification", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contrats", "Qualification", c => c.String());
        }
    }
}
