using System.Collections.Generic;
using AutoMapper;

namespace CV.Application.Mappers
{
    public static class AccountMapper
    {
        /// <summary>
        /// convert to Account DTO
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static AccountDTO ConvertToAccountDTO(this Account account)
        {
            Mapper.CreateMap<Account, AccountDTO>()
                  .ForMember(acc => acc.AccountId, ac => ac.MapFrom(a => a.Id));
            return Mapper.Map<Account, AccountDTO>(account);
        }



        /// <summary>
        /// Converet to Account Model
        /// </summary>
        /// <param name="accountDTO"></param>
        /// <returns></returns>
        public static Account ConvertToAccountModel(this AccountDTO accountDTO)
        {
            return Mapper.Map<AccountDTO, Account>(accountDTO);
        }



        /// <summary>
        /// Convert to Register DTO List 
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static IEnumerable<AccountDTO> ConvertToRegisterDTOList(this IEnumerable<Account> account)
        {
            AutoMapper.Mapper.CreateMap<Account, AccountDTO>()
                  .ForMember(acc => acc.AccountId, ac => ac.MapFrom(a => a.Id));
            return Mapper.Map<IEnumerable<Account>, IEnumerable<AccountDTO>>(account);
        }
    }
}
