namespace GodelTech.AreaMonitor.DAL.Models
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public string Email { get; set; }

        public string RefreshToken { get; set; }

        public int Status { get; set; }
    }
}
