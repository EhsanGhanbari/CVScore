using System.Collections.Generic;
using CV.Application.DTO.Accounts;

namespace CV.Application.Messaging.Accounts
{
    public class GetAllAccountResponse
    {
        public IEnumerable<AccountDTO> AccountDTO { get; set; }
    }
}
