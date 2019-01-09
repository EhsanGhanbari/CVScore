using System.Collections.Generic;
using CvScore.MetaData.Accounts;

namespace CvScore.Application.Messaging.Accounts
{
    public class GetAllAccountResponse
    {
        public IEnumerable<AccountDTO> AccountDTO { get; set; }
    }
}
