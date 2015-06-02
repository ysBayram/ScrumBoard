using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entity;

namespace Provider
{
    public class SBContext : DbContext, IDisposable
    {
        public DbSet<SBCategory> Categories { get; set; }
        public DbSet<SBSprint> Sprints { get; set; }
        public DbSet<SBTask> Tasks { get; set; }
        public DbSet<SBMeeting> Meetings { get; set; }
        public DbSet<SBUser> Users { get; set; }

        public SBContext()
        {
            Database.SetInitializer(new MyDatabaseInitializer());
        }
    }
}
