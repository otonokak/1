using GodelTech.AreaMonitor.Bll.Enum;

namespace GodelTech.AreaMonitor.Bll.Dto
{
    public class UserDto
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public string Email { get; set; }

        public string RefreshToken { get; set; }

        public UserStatus Status { get; set; }
    }
}
