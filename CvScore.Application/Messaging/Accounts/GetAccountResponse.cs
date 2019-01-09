using CvScore.MetaData.Accounts;

namespace CvScore.Application.Messaging.Accounts
{
    public class GetAccountResponse :BaseResponse
    {
        public AccountDTO AccountDTO { get; set; }
    }
}
