using System.Data.Entity;

namespace GodelTech.AreaMonitor.DAL.Context
{
    public class AreaMonitorContextInitializer : CreateDatabaseIfNotExists<AreaMonitorContext>
    {
        protected override void Seed(AreaMonitorContext context)
        {
        }
    }
}