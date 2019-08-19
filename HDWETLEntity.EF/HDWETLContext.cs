using HDWETLEntity.Poco.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDWETLEntity.EF
{
    public class HDWETLContext : DbContext 
    {
        public HDWETLContext() : base("HDWETLConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<HDWETLContext, Migrations.Configuration>("HDWETLConnection"));
        }

        public DbSet<ETLSchedule> ETLSchedules { get; set; }
        public DbSet<ETLScheduleLog> ETLScheduleLogs { get; set; }
    }
}
