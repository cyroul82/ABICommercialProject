namespace ABICommercialProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertyRequiredAndLengthToCollaborateurTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Collaborateurs", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Collaborateurs", "Firstname", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Collaborateurs", "Firstname", c => c.String());
            AlterColumn("dbo.Collaborateurs", "Name", c => c.String());
        }
    }
}
