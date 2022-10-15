namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AuthTokens",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Token = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        ExpiresIn = c.Int(nullable: false),
                        ExpiresTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.EmailConfigs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                        EmailAddress = c.String(),
                        Email_Server = c.String(),
                        Email_LoginId = c.String(),
                        Email_LoginPwd = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmailTaskConfigs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                        IsSendNow = c.Boolean(),
                        TaskTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmailTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                        IsSend = c.Boolean(),
                        SendTime = c.DateTime(nullable: false),
                        EmailContent = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.TodayWorkDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        WorkId = c.Guid(nullable: false),
                        Seq = c.Int(nullable: false),
                        WorkDetails = c.String(),
                        AffiliatedProject = c.String(),
                        JIRANumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TomorrowWorkDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        WorkId = c.Guid(nullable: false),
                        Seq = c.Int(nullable: false),
                        WorkDetails = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        RoleId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        DepartmentId = c.Guid(),
                        WeChatUserid = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Works",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        WorkDate = c.DateTime(),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Works");
            DropTable("dbo.Users");
            DropTable("dbo.UserRoles");
            DropTable("dbo.TomorrowWorkDetails");
            DropTable("dbo.TodayWorkDetails");
            DropTable("dbo.ThirdPartyDepartmentMappings");
            DropTable("dbo.Roles");
            DropTable("dbo.EmailTasks");
            DropTable("dbo.EmailTaskConfigs");
            DropTable("dbo.EmailConfigs");
            DropTable("dbo.Departments");
            DropTable("dbo.Contacts");
            DropTable("dbo.AuthTokens");
        }
    }
}
