namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_20220928 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Name", c => c.String());
            AddColumn("dbo.Users", "DepartmentId", c => c.Guid());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "DepartmentId");
            DropColumn("dbo.Users", "Name");
        }
    }
}
