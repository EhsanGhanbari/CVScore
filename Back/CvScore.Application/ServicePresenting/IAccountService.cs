using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CV.Application.Messaging.Accounts;

namespace CV.Application.ServicePresenting
{
    public interface IAccountService
    {
        CreateAccountResponse CreateAccount(CreateAccountRequest request);
        GetAccountResponse GetAccount(GetAccountRequest request);
        GetAllAccountResponse GetAllAccount(GetAllAccountRequest request);
        RemoveAccountResponse RemoveAccount(RemoveAccountRequest request);
        UpdateAccountResponse UpdateAccount(UpdateAccountRequest request);
    }
}
