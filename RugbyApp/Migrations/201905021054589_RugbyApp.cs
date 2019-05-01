namespace RugbyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RugbyApp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParentsDetails", "p2Fname", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ParentsDetails", "p2Fname");
        }

        internal class Models
        {
            internal class AppDbContext
            {
            }
        }
    }
}
