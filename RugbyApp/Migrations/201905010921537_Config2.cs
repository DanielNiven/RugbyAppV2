namespace RugbyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Config2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.JuniorsDetails", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.JuniorsDetails", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.JuniorsDetails", "Email", c => c.String());
            AlterColumn("dbo.JuniorsDetails", "PhoneNumber", c => c.String());
        }
    }
}
