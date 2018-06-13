using System.Data.Entity.ModelConfiguration;
using GodelTech.AreaMonitor.DAL.Models;

namespace GodelTech.AreaMonitor.DAL.Context.Configurations
{
    public class UserConfigurations : EntityTypeConfiguration<User>
    {
        public UserConfigurations()
        {
            HasKey(x => x.Id);
            Property(x => x.UserName).IsRequired().HasMaxLength(256);
            Property(x => x.Email).HasMaxLength(256);
            HasIndex(x => x.Email).IsUnique();
            Property(x => x.RefreshToken).HasMaxLength(256);
        }
    }
}
