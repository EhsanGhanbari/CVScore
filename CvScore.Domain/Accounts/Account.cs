using System;

namespace CvScore.Domain.Accounts
{
    public class Account : IAggregateRoot
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreationTime { get; set; }

    }
}
