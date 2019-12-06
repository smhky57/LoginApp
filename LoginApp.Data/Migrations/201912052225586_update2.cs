namespace LoginApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "HashType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "HashType");
        }
    }
}
