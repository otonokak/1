using System.Data.Entity;
using GodelTech.AreaMonitor.Dal.Models;

namespace GodelTech.AreaMonitor.Dal.Context
{
    public class AreaMonitorContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserWebPage> UserWebPages { get; set; }
        public DbSet<WebPage> WebPages { get; set; }
        public DbSet<WebPageUpdate> WebPageUpdates { get; set; }

        public AreaMonitorContext()
            : base("AreaMonitorDatabase")
        {
        }
    }
}