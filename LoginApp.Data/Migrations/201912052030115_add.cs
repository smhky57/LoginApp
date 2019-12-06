namespace LoginApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                        lastLogintime = c.DateTime(nullable: false),
                        Stat = c.Int(nullable: false),
                        lastUpdateDate = c.DateTime(nullable: false),
                        recordStat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
