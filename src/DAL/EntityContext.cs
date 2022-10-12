using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EntityContext : DbContext
    {
        public EntityContext()
            : base("name=CodeFirstDb")
        {
            Database.SetInitializer<EntityContext>(null);
            //自动创建表，如果Entity有改到就更新到表结构
            //Database.SetInitializer<EntityContext>(new MigrateDatabaseToLatestVersion<EntityContext, ReportingDbMigrationsConfiguration>());
        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //表名为类名，不是带s的表名  //移除复数表名的契约
        //}

        //internal sealed class ReportingDbMigrationsConfiguration : DbMigrationsConfiguration<EntityContext>
        //{
        //    public ReportingDbMigrationsConfiguration()
        //    {
        //        AutomaticMigrationDataLossAllowed = true;
        //        AutomaticMigrationsEnabled = true;//任何Model Class的修改将会更新DB
        //    }
        //}

        public DbSet<Works> Works { get; set; }
        public DbSet<TodayWorkDetails> TodayWorkDetails { get; set; }

        public DbSet<TomorrowWorkDetails> TomorrowWorkDetails { get; set; }

        public DbSet<Contacts> Contacts { get; set; }

        public DbSet<EmailConfig> EmailConfigs { get; set; }

        public DbSet<EmailTaskConfig> EmailTaskConfigs { get; set; }

        public DbSet<EmailTask> EmailTasks { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<AuthToken> AuthTokens { get; set; }

        public DbSet<ThirdPartyDepartmentMapping> ThirdPartyDepartmentMappings { get; set; }

        public DbSet<Roles> Roles { get; set; }

        public DbSet<UserRoles> UserRoles { get; set; }
    }
}
