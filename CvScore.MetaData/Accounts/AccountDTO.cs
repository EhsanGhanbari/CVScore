using System;

namespace CvScore.MetaData.Accounts
{
    public class AccountDTO
    {
        public Guid AccountId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
