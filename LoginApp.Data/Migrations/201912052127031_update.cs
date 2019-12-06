namespace LoginApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "lastLogintime", c => c.DateTime());
            AlterColumn("dbo.Users", "lastUpdateDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "lastUpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "lastLogintime", c => c.DateTime(nullable: false));
        }
    }
}
