using System;
using CvScore.Domain.Accounts;
using Raven.Client;

namespace CvScore.Data
{
    public class AccountRepository : Repository<Account, Guid>, IAccountRepository
    {
        public AccountRepository(IDocumentSession documentSession)
            : base(documentSession)
        {
        }
    }
}
