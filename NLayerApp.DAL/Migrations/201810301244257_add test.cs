namespace NLayerApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "test", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "test");
        }
    }
}
