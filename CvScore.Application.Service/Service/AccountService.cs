using CvScore.Application.Mappers;
using CvScore.Application.Messaging.Accounts;
using CvScore.Application.Service.IService;
using CvScore.Domain.Accounts;

namespace CvScore.Application.Service.Service
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }


        /// <summary>
        /// Create account
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateAccountResponse CreateAccount(CreateAccountRequest request)
        {
            var response = new CreateAccountResponse();
            var account = request.AccountDTO.ConvertToAccountModel();
            _accountRepository.Add(account);
            return response;
        }



        /// <summary>
        /// Get Account by Details
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAccountResponse GetAccount(GetAccountRequest request)
        {
            var response = new GetAccountResponse();
            var account = _accountRepository.FindBy(request.AccountDTO.AccountId);
            response.AccountDTO = account.ConvertToAccountDTO();
            return response;
        }


        /// <summary>
        /// Get All Account
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllAccountResponse GetAllAccount(GetAllAccountRequest request)
        {
            var response = new GetAllAccountResponse();
            var accounts = _accountRepository.FindAll();
            response.AccountDTO = accounts.ConvertToRegisterDTOList();
            return response;
        }


        /// <summary>
        /// Remove Account
        /// This is onle Done By Admin 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveAccountResponse RemoveAccount(RemoveAccountRequest request)
        {
            var respons = new RemoveAccountResponse();
            var account = request.AccountDTO.ConvertToAccountModel();
            _accountRepository.Remove(account);
            return respons;
        }


        /// <summary>
        /// Update Account
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateAccountResponse UpdateAccount(UpdateAccountRequest request)
        {
            var response = new UpdateAccountResponse();
            var account = request.AccountDTO.ConvertToAccountModel();
            _accountRepository.Remove(account);
            return response;
        }
    }
}
