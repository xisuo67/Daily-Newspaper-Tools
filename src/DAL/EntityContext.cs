using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        }

        public DbSet<Works> Works { get; set; }
        public DbSet<TodayWorkDetails> TodayWorkDetails { get; set; }

        public DbSet<TomorrowWorkDetails> TomorrowWorkDetails { get; set; }

        public DbSet<Contacts> Contacts { get; set; }

        public DbSet<EmailConfig> EmailConfigs { get; set; }

        public DbSet<EmailTaskConfig> EmailTaskConfigs { get; set; }

        public DbSet<EmailTask> EmailTasks { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}
