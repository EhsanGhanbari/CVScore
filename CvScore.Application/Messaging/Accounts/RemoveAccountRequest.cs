using CvScore.MetaData.Accounts;

namespace CvScore.Application.Messaging.Accounts
{
    public class RemoveAccountRequest
    {
        public AccountDTO AccountDTO { get; set; }

        public RemoveAccountRequest(AccountDTO accountDTO)
        {
            AccountDTO = accountDTO;
        }
    }
}
