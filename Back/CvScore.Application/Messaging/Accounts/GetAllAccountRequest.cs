using CV.Application.DTO.Accounts;

namespace CV.Application.Messaging.Accounts
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
