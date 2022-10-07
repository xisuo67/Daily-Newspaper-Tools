namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_20221007 : DbMigration
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
            
            AddColumn("dbo.Users", "WeChatUserid", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "WeChatUserid");
            DropTable("dbo.AuthTokens");
        }
    }
}
