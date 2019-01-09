using System;
using CV.Application.Mappers;
using CV.Application.Messaging.Accounts;
using CV.Application.ServicePresenting;
using CV.Repository.UnitOfWork;
using CV.Model.Accounts;

namespace CV.Application.Service
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AccountService(IAccountRepository accountRepository, IUnitOfWork unitOfWork)
        {
            _accountRepository = accountRepository;
            _unitOfWork = unitOfWork;
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
            _unitOfWork.Commit();
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
            _unitOfWork.Commit();
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
            _unitOfWork.Commit();
            return response;
        }
    }
}
