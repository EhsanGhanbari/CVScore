using CV.Application.DTO.Accounts;

namespace CV.Application.Messaging.Accounts
{
    public class GetAccountRequest
    {
        internal AccountDTO AccountDTO { get; set; }

        public GetAccountRequest(AccountDTO accountDTO)
        {
            AccountDTO = accountDTO;
        }
    }
}
