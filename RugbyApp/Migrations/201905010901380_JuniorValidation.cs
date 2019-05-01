namespace RugbyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JuniorValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.JuniorsDetails", "FName", c => c.String(nullable: false));
            AlterColumn("dbo.JuniorsDetails", "LName", c => c.String(nullable: false));
            AlterColumn("dbo.JuniorsDetails", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.JuniorsDetails", "Address", c => c.String());
            AlterColumn("dbo.JuniorsDetails", "Phone number", c => c.String());
            AlterColumn("dbo.JuniorsDetails", "Email", c => c.String());
        }
    }
}
