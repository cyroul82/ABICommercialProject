namespace ABICommercialProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedColumnTypeDateToAugmentationSalaireTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AugmentationSalaires", "Date", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AugmentationSalaires", "Date", c => c.DateTime(nullable: false));
        }
    }
}
