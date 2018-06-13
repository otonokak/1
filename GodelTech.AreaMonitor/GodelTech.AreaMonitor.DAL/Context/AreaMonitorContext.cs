using System.Data.Entity;

namespace GodelTech.AreaMonitor.DAL.Context
{
    public class AreaMonitorContext : DbContext
    {
        public AreaMonitorContext()
            : base("AreaMonitorDatabase")
        {
            Database.SetInitializer(new AreaMonitorContextInitializer());
            Database.Initialize(false);
        }
    }
}