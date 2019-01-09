using CV.Application.DTO.Accounts;

namespace CV.Application.Messaging.Accounts
{
    public class CreateAccountRequest
    {
        internal AccountDTO AccountDTO { get; private set; }

        public CreateAccountRequest(AccountDTO accountDTO)
        {
            AccountDTO = accountDTO;
        }
    }
}
