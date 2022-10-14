namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_20221014 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Roles");
            AlterColumn("dbo.Roles", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Roles", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Roles");
            AlterColumn("dbo.Roles", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Roles", "Id");
        }
    }
}
