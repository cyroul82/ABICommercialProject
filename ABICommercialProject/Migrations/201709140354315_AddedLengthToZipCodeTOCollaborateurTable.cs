namespace ABICommercialProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLengthToZipCodeTOCollaborateurTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Collaborateurs", "ZipCode", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Collaborateurs", "ZipCode", c => c.String());
        }
    }
}
