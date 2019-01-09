using CvScore.MetaData.Accounts;

namespace CvScore.Application.Messaging.Accounts
{
    public class UpdateAccountRequest
    {
        public AccountDTO AccountDTO { get; private set; }

        public UpdateAccountRequest(AccountDTO accountDTO)
        {
            AccountDTO = accountDTO;
        }
    }
}
