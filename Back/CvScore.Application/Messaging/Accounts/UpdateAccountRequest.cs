using CV.Application.DTO.Accounts;

namespace CV.Application.Messaging.Accounts
{
    public class UpdateAccountRequest
    {
        internal AccountDTO AccountDTO { get; private set; }

        public UpdateAccountRequest(AccountDTO accountDTO)
        {
            AccountDTO = accountDTO;
        }
    }
}
