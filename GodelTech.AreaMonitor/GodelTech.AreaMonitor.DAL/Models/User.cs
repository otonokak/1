using GodelTech.AreaMonitor.Dal.Enum;

namespace GodelTech.AreaMonitor.Dal.Models
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public string Email { get; set; }

        public string RefreshToken { get; set; }

        public UserStatus Status { get; set; }
    }
}
