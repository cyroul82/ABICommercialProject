namespace ABICommercialProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompositeUniqueKeyofNameAndFirstnameToCollorateurTable : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Collaborateurs", new[] { "Name", "Firstname" }, unique: true, name: "IX_NameFirstname");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Collaborateurs", "IX_NameFirstname");
        }
    }
}
