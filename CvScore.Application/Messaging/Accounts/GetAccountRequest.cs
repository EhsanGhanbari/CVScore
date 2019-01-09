using CvScore.MetaData.Accounts;

namespace CvScore.Application.Messaging.Accounts
{
    public class GetAccountRequest
    {
        public AccountDTO AccountDTO { get; set; }

        public GetAccountRequest(AccountDTO accountDTO)
        {
            AccountDTO = accountDTO;
        }
    }
}
