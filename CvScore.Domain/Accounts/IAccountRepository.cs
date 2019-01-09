using System;

namespace CvScore.Domain.Accounts
{
    public interface IAccountRepository : IRepository<Account, Guid>
    {
    }
}
