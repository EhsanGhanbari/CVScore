using CV.Application.DTO.Accounts;

namespace CV.Application.Messaging.Accounts
{
    public class RemoveAccountRequest
    {
        internal AccountDTO AccountDTO { get; set; }

        public RemoveAccountRequest(AccountDTO accountDTO)
        {
            AccountDTO = accountDTO;
        }
    }
}
