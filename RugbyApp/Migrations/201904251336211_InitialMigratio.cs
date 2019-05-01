namespace RugbyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigratio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JuniorsDetails",
                c => new
                    {
                        SruNumber = c.Int(nullable: false, identity: true),
                        FName = c.String(),
                        LName = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.SruNumber);
            
            CreateTable(
                "dbo.ParentsDetails",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        p1FName = c.String(),
                        p1SName = c.String(),
                        p1Relation = c.String(),
                        p1Address = c.String(),
                        p1PhoneNumber = c.String(),
                        p2Sname = c.String(),
                        p2Relation = c.String(),
                        p2Address = c.String(),
                        p2PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ParentsDetails");
            DropTable("dbo.JuniorsDetails");
        }
    }
}
