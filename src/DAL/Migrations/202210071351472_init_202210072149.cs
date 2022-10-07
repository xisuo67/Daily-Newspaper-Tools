namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_202210072149 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ThirdPartyDepartmentMappings",
                c => new
                    {
                        DepartmentMappingId = c.Guid(nullable: false),
                        ThirdPartyId = c.String(),
                        Name = c.String(),
                        order = c.String(),
                        DepartmentMappingParentId = c.Guid(),
                        ThirdPartyParentId = c.String(),
                        FromSystem = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DepartmentMappingId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ThirdPartyDepartmentMappings");
        }
    }
}
