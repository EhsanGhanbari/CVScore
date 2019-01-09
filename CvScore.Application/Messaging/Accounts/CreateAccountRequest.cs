using CvScore.MetaData.Accounts;

namespace CvScore.Application.Messaging.Accounts
{
    public class CreateAccountRequest
    {
        public AccountDTO AccountDTO { get; private set; }

        public CreateAccountRequest(AccountDTO accountDTO)
        {
            AccountDTO = accountDTO;
        }
    }
}
