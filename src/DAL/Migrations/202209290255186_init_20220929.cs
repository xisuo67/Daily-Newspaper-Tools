namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_20220929 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Code = c.String(),
                        ParentId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "Name", c => c.String());
            AddColumn("dbo.Users", "DepartmentId", c => c.Guid());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "DepartmentId");
            DropColumn("dbo.Users", "Name");
            DropTable("dbo.Departments");
        }
    }
}
