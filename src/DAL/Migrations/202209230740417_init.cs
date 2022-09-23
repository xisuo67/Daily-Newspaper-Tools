namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
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
                "dbo.Users",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
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
            DropTable("dbo.TomorrowWorkDetails");
            DropTable("dbo.TodayWorkDetails");
            DropTable("dbo.EmailTasks");
            DropTable("dbo.EmailTaskConfigs");
            DropTable("dbo.EmailConfigs");
            DropTable("dbo.Contacts");
        }
    }
}
