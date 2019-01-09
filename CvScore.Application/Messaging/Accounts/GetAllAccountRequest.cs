using CvScore.MetaData.Accounts;

namespace CvScore.Application.Messaging.Accounts
{
    public class GetAllAccountRequest
    {
        internal AccountDTO AccountDTO { get; set; }

        public GetAllAccountRequest(AccountDTO accountDTO)
        {
            AccountDTO = accountDTO;
        }
    }
}
