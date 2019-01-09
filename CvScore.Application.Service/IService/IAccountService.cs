using System.ServiceModel;
using CvScore.Application.Messaging.Accounts;

namespace CvScore.Application.Service.IService
{
    [ServiceContract]
    public interface IAccountService
    {
        [OperationContract]
        CreateAccountResponse CreateAccount(CreateAccountRequest request);
        
        [OperationContract]
        GetAccountResponse GetAccount(GetAccountRequest request);
        
        [OperationContract]
        GetAllAccountResponse GetAllAccount(GetAllAccountRequest request);
        
        [OperationContract]
        RemoveAccountResponse RemoveAccount(RemoveAccountRequest request);
        
        [OperationContract]
        UpdateAccountResponse UpdateAccount(UpdateAccountRequest request);
    }
}
