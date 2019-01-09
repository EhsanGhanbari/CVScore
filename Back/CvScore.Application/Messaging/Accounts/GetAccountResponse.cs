using CV.Application.DTO.Accounts;

namespace CV.Application.Messaging.Accounts
{
    public class GetAccountResponse :BaseResponse
    {
        public AccountDTO AccountDTO { get; set; }
    }
}
